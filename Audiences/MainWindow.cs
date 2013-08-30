using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Microsoft.Office.Server.Audience;
using System.Collections;

namespace Audiences
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs ea)
        {
        }
        AudienceCollection ac;
        private void loadButton_Click(object sender, EventArgs e)
        {
            loadButton.Enabled = false;
            audienceList.ClearSelected();
            if (currentAudience != null)
                reloadAudience = true;
            try
            {
                using (SPSite site = new SPSite(URLBox.Text))
                {
                    SPServiceContext context = SPServiceContext.GetContext(site);
                    AudienceManager audManager = new AudienceManager(context);

                    ac = audManager.Audiences;

                    audienceList.Items.Clear();
                    foreach (Audience aud in ac)
                    {
                        if (aud.AudienceID == Guid.Empty)
                            continue;
                        audienceList.Items.Add(aud.AudienceName);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("There was an error loading the audiences. Error message was:\r\n\r\n" + exc.Message);
            }
            loadButton.Enabled = true;
            if (currentAudience != null)
                audienceList.SelectedItem = currentAudience.AudienceName;
        }

        private Audience getSelectedAudience()
        {
            string audName = (string)audienceList.SelectedItem;
            return ac[audName];
        }

        bool loadingRulesFlag = false;
        bool reloadAudience = false;
        Audience currentAudience = null;

        private void audienceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAudience();
        }

        private void loadAudience()
        {
            Audience aud = getSelectedAudience();

            if (aud == null)
                return;

            if (!reloadAudience && currentAudience != null && currentAudience.AudienceID == aud.AudienceID)
                return;

            if (rulesModified)
            {
                DialogResult dr = MessageBox.Show("You have modified this set of rules. If you change the audience you will lose the changes. Stay in this audience?", "Rules modified", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    audienceList.SelectedItem = currentAudience.AudienceName;
                    return;
                }
            }
            rulesModified = false;
            reloadAudience = false;

            currentAudience = aud;
            string details = String.Format("Name: {0}\r\nGUID: {1}\r\nDescription: {2}\r\nType: {3}\r\nMember count: {4}\r\nCompilation status: {5}\r\nLast compilation: {6}"
                , aud.AudienceName
                , aud.AudienceID
                , aud.AudienceDescription
                , aud.GroupOperation
                , aud.MemberShipCount
                , aud.LastRuleUpdate > aud.LastCompilation ? "Not compiled" : "Compiled"
                , aud.LastCompilation
                );
            audienceDetailsLabel.Text = details;

            rulesView.Items.Clear();
            if (aud.AudienceRules != null)
            {
                loadingRulesFlag = true;
                foreach (AudienceRuleComponent c in aud.AudienceRules)
                {
                    ListViewItem it = new ListViewItem();
                    it.Text = c.LeftContent;
                    it.SubItems.Add(c.Operator);
                    it.SubItems.Add(c.RightContent);
                    rulesView.Items.Add(it);
                }
                loadingRulesFlag = false;
            }
        }

        private void rulesView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (loadingRulesFlag)
                return;
            //if item checked enable remove rules button
            if (e.Item.Checked)
                removeRulesButton.Enabled = true;
            else if (rulesView.CheckedItems.Count == 0)
                removeRulesButton.Enabled = false;
            //is selected audience an OR audience?
            Audience aud = getSelectedAudience();
            if (aud.GroupOperation != AudienceGroupOperation.AUDIENCE_OR_OPERATION
                && aud.GroupOperation != AudienceGroupOperation.AUDIENCE_AND_OPERATION)
                return;
            int idx = rulesView.Items.IndexOf(e.Item);
            if (idx > 0)
            {
                if ((idx & 1) == 0) //even, rule, select previous
                {
                    rulesView.Items[idx - 1].Checked = e.Item.Checked;
                }
                else //odd, operator, select next
                {
                    rulesView.Items[idx + 1].Checked = e.Item.Checked;
                }
            }
        }

        private bool _modified = false;
        private bool rulesModified
        {
            get
            {
                return _modified;
            }
            set
            {
                _modified = value;
                saveRulesButton.Enabled = value;
            }
        }

        private void removeRulesButton_Click(object sender, EventArgs e)
        {
            rulesModified = true;
            foreach (ListViewItem i in rulesView.CheckedItems)
            {
                i.Remove();
            }
            //check that the first rule is not an operator, if it is, remove it
            if (rulesView.Items.Count == 0)
                return;
            ListViewItem first = rulesView.Items[0];
            if (first.SubItems[0].Text.Length == 0
                && (first.SubItems[1].Text.Equals("AND")
                    || first.SubItems[1].Text.Equals("OR"))
                && first.SubItems[2].Text.Length == 0)
                first.Remove();
        }

        private void saveRulesButton_Click(object sender, EventArgs e)
        {
            ArrayList newRules = new ArrayList();
            foreach (ListViewItem i in rulesView.Items)
            {
                AudienceRuleComponent c = new AudienceRuleComponent(i.SubItems[0].Text, i.SubItems[1].Text, i.SubItems[2].Text);
                newRules.Add(c);
            }

            Audience aud = getSelectedAudience();
            aud.AudienceRules = newRules;
            try
            {
                aud.Commit();
                rulesModified = false;
                reloadAudience = true;
                loadAudience();
            }
            catch (Exception exc)
            {
                MessageBox.Show("There was an error commiting the changes. The error message was:\r\n\r\n" + exc.Message);
            }
            saveRulesButton.Enabled = false;
        }
    }
}
