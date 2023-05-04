using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.SqlServer.Replication;
using Microsoft.SqlServer.Management.Common;

namespace TravelExpenses
{
    public partial class Sync : Form
    {
        string subscriberName = ".\\SQLEXPRESS";
        string publisherName = "lcmcdsql\\Publisher";
        string publicationName = "TravelExpenses";
        string subscriptionDbName = "TravelExpenses";
        string publicationDbName = "TravelExpenses";
        MergeSynchronizationAgent agent;
        BackgroundWorker syncBackgroundWorker;
        public Sync()
        {
            InitializeComponent();
            System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged += new System.Net.NetworkInformation.NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);
            lblSubscriptionName.Text = "[" + subscriptionDbName + "] - [" + publisherName + "]";
            lblPublicationName.Text = publicationName;
        }

        delegate void EnableCallback();

        void NetworkChange_NetworkAvailabilityChanged(object sender, System.Net.NetworkInformation.NetworkAvailabilityEventArgs e)
        {
            EnableSync();
        }
        private void EnableSync()
        {
            if (this.btnSync.InvokeRequired)
            {
                EnableCallback methodCallback = new EnableCallback(EnableSync);
                this.Invoke(methodCallback, new object[] { });
            }
            else
            {
                btnSync.Enabled = !btnSync.Enabled;
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            syncBackgroundWorker = new BackgroundWorker();
            syncBackgroundWorker.WorkerReportsProgress = true;
            syncBackgroundWorker.DoWork += new DoWorkEventHandler(syncBackgroundWorker_DoWork);
            syncBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(syncBackgroundWorker_ProgressChanged);
            syncBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(syncBackgroundWorker_RunWorkerCompleted);

            btnSync.Enabled = false;
            pbStatus.Value = 0;
            txtSyncDetails.Text = string.Empty;

            syncBackgroundWorker.RunWorkerAsync();
        }

        void syncBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                txtSyncDetails.Text += "Canceled!" + Environment.NewLine;
                ScrollToEnd();
            }
            else if (e.Error != null)
            {
                txtSyncDetails.Text += "Error: " + e.Error.Message + Environment.NewLine;
                MessageBox.Show("Syncing did not complete, please contact administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScrollToEnd();
            }
            else
            {
                txtSyncDetails.Text += "Done!" + Environment.NewLine;
                ScrollToEnd();

                MessageBox.Show("Data Sync Complete!");
                this.Close();
            }

            btnSync.Enabled = true;
            //pictureBoxStatus.Enabled = false;
        }

        void syncBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Set the progress bar percent completed
            pbStatus.Value = e.ProgressPercentage;

            // Append the last agent message
            txtSyncDetails.Text += e.UserState.ToString() + Environment.NewLine;

            // Scroll to end
            ScrollToEnd();
        }

        void syncBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SynchronizeMergePullSubscriptionViaRMO();
        }

        public void SynchronizeMergePullSubscriptionViaRMO()
        {
            // Create a connection to the Subscriber.
            ServerConnection conn = new ServerConnection(subscriberName);
            conn.LoginSecure = false;
            conn.Login = "Administrator";
            conn.Password = "insectary";

            MergePullSubscription subscription;

            try
            {
                // Connect to the Subscriber.
                conn.Connect();

                // Define the pull subscription.
                subscription = new MergePullSubscription();
                subscription.ConnectionContext = conn;
                subscription.DatabaseName = subscriptionDbName;
                subscription.PublisherName = publisherName;
                subscription.PublicationDBName = publicationDbName;
                subscription.PublicationName = publicationName;

                // If the pull subscription exists, then start the synchronization.
                if (subscription.LoadProperties())
                {
                    // Get the agent for the subscription.
                    agent = subscription.SynchronizationAgent;

                    // Set the required properties that could not be returned
                    // from the MSsubscription_properties table.
                    agent.PublisherSecurityMode = SecurityMode.Integrated;
                    agent.DistributorSecurityMode = SecurityMode.Integrated;
                    agent.Distributor = publisherName;

                    // Enable agent output to the console.
                    //agent.OutputVerboseLevel = 4;
                    //agent.Output = "C:\\TEMP\\mergeagent.log";

                    agent.Status += new AgentCore.StatusEventHandler(agent_Status);

                    // Synchronously start the Merge Agent for the subscription.
                    agent.Synchronize();
                }
                else
                {
                    // Do something here if the pull subscription does not exist.
                    throw new ApplicationException(String.Format(
                        "A subscription to '{0}' does not exist on {1}",
                        publicationName, subscriberName));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);       
                //// Implement appropriate error handling here.
                throw new ApplicationException("The subscription could not be " +
                    "synchronized. Verify that the subscription has " +
                    "been defined correctly.", ex);
            }
            finally
            {
                conn.Disconnect();
            }
        }

        public void agent_Status(object sender, StatusEventArgs e)
        {
            syncBackgroundWorker.ReportProgress(Convert.ToInt32(e.PercentCompleted), e.Message.ToString());
        }
        private void ScrollToEnd()
        {
            // Scroll to end
            txtSyncDetails.SelectionStart = txtSyncDetails.TextLength;
            txtSyncDetails.ScrollToCaret();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
