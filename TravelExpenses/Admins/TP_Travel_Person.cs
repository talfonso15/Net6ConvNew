using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TravelExpenses
{
    public partial class TP_Travel_Person : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        bool first = true;
        public TP_Travel_Person()
        {
            InitializeComponent();
        }

        private void TP_Travel_Person_Load(object sender, EventArgs e)
        {
            localCon.Open();
            string name = "";
            string department = "";
            string userID = "";
            //first = true;
            if (CommonVariables.isGroup)
            {
                dgvEmployees.MultiSelect = true;
            }
            else
            {
                dgvEmployees.MultiSelect = false;
            }
            


            SqlCommand users = new SqlCommand("SELECT  [UserID] ,CONCAT([Name],' ',[LastName]) as Name ,[Department] FROM [TravelExpenses].[dbo].[User] order by Name", localCon);
            SqlDataReader usersDR = users.ExecuteReader();
            
            while (usersDR.Read())
            {
                name = usersDR["Name"].ToString();
                department = usersDR["Department"].ToString();
                userID = usersDR["UserID"].ToString();

                dgvEmployees.Rows.Add(false, name, department, userID);
            }
            usersDR.Close();
            localCon.Close();
            first = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            CommonVariables.is_TPT = false;
            CommonVariables.isGroup = false;
            CommonVariables.tpt_Type = "";
            CommonVariables.usersID = new List<string>();
        }

        private void dgvEmployees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!first)
            {
                if (!CommonVariables.isGroup)
                {
                    int index = dgvEmployees.CurrentRow.Index;
                    bool selected = Convert.ToBoolean(dgvEmployees.Rows[index].Cells[0].Value.ToString());
                    dgvEmployees.EndEdit();
                    if (selected)
                    {
                        foreach (DataGridViewRow row in this.dgvEmployees.Rows)
                        {
                            if (row.Index != index)
                            {
                                row.Cells[0].Value = false;
                            }

                        }
                    }
                }
            }
        }

        private void dgvEmployees_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (!CommonVariables.isGroup)
            {
                if (dgvEmployees.IsCurrentCellDirty)
                {
                    dgvEmployees.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (CommonVariables.isGroup)
            {
                foreach (DataGridViewRow row in this.dgvEmployees.Rows)
                {
                    bool selected = Convert.ToBoolean(row.Cells[0].Value);
                    if (selected)
                    {
                        string userID = row.Cells[3].Value.ToString();
                        CommonVariables.usersID.Add(userID);
                    }
                }
               // int cant = CommonVariables.usersID.Count;
            }
            else
            {
                foreach (DataGridViewRow row in this.dgvEmployees.Rows)
                {
                    bool selected = Convert.ToBoolean(row.Cells[0].Value);
                    if (selected)
                    {
                        CommonVariables.tpt_UserID = row.Cells[3].Value.ToString();
                    }
                }
                //string number = CommonVariables.tpt_UserID;
            }

            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                    Form[] childs = frm.MdiChildren;
                  
                }
            }

            if (CommonVariables.tpt_Type == "Authorization")
            {
                EstimateTravel et = new EstimateTravel();
                et.MdiParent = main;
                et.Show();
                this.Close();
            }
            else if(CommonVariables.tpt_Type == "Travel")
            {
                RegisterTravel rt = new RegisterTravel();
                rt.MdiParent = main;
                rt.Show();
                this.Close();
            }
            
        }
    }
}
