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
    public partial class CreateSignature : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        public CreateSignature()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSignatureText.Text != "")
            {
                if (rbMistral.Checked)
                {
                    lblSignaturePreviewvalue.Font = new Font("Mistral", lblSignaturePreviewvalue.Font.Size);
                    lblSignaturePreviewvalue.Text = txtSignatureText.Text;
                }
                if (rbRageItalic.Checked)
                {
                    lblSignaturePreviewvalue.Font = new Font("Rage Italic", lblSignaturePreviewvalue.Font.Size);
                    lblSignaturePreviewvalue.Text = txtSignatureText.Text;
                }
                if (rbMVBoli.Checked)
                {
                    lblSignaturePreviewvalue.Font = new Font("MV Boli", lblSignaturePreviewvalue.Font.Size);
                    lblSignaturePreviewvalue.Text = txtSignatureText.Text;
                }
                if (rbBradleyHand.Checked)
                {
                    lblSignaturePreviewvalue.Font = new Font("Bradley Hand ITC", lblSignaturePreviewvalue.Font.Size);
                    lblSignaturePreviewvalue.Text = txtSignatureText.Text;
                }
                if (rbScriptMTBold.Checked)
                {
                    lblSignaturePreviewvalue.Font = new Font("Script MT Bold", lblSignaturePreviewvalue.Font.Size);
                    lblSignaturePreviewvalue.Text = txtSignatureText.Text;
                }
            }
        }

        private void rbMistral_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMistral.Checked && txtSignatureText.Text != "")
            {
                lblSignaturePreviewvalue.Font = new Font("Mistral", lblSignaturePreviewvalue.Font.Size);
                lblSignaturePreviewvalue.Text = txtSignatureText.Text;
            }
        }

        private void rbRageItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRageItalic.Checked && txtSignatureText.Text != "")
            {
                lblSignaturePreviewvalue.Font = new Font("Rage Italic", lblSignaturePreviewvalue.Font.Size);
                lblSignaturePreviewvalue.Text = txtSignatureText.Text;
            }
        }

        private void rbMVBoli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMVBoli.Checked && txtSignatureText.Text != "")
            {
                lblSignaturePreviewvalue.Font = new Font("MV Boli", lblSignaturePreviewvalue.Font.Size);
                lblSignaturePreviewvalue.Text = txtSignatureText.Text;
            }
        }

        private void rbBradleyHand_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBradleyHand.Checked && txtSignatureText.Text != "")
            {
                lblSignaturePreviewvalue.Font = new Font("Bradley Hand ITC", lblSignaturePreviewvalue.Font.Size);
                lblSignaturePreviewvalue.Text = txtSignatureText.Text;
            }
        }

        private void rbScriptMTBold_CheckedChanged(object sender, EventArgs e)
        {
            if (rbScriptMTBold.Checked && txtSignatureText.Text != "")
            {
                lblSignaturePreviewvalue.Font = new Font("Script MT Bold", lblSignaturePreviewvalue.Font.Size);
                lblSignaturePreviewvalue.Text = txtSignatureText.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (Validate())
            {
                if (rbMistral.Checked)
                {
                    CommonVariables.signatureFont = "Mistral";
                }
                else if (rbRageItalic.Checked)
                {
                    CommonVariables.signatureFont = "Rage Italic";
                }
                else if (rbMVBoli.Checked)
                {
                    CommonVariables.signatureFont = "MV Boli";
                }
                else if (rbBradleyHand.Checked)
                {
                    CommonVariables.signatureFont = "Bradley Hand ITC";
                }
                else if (rbScriptMTBold.Checked)
                {
                    CommonVariables.signatureFont = "Script MT Bold";
                }
                CommonVariables.signatureText = txtSignatureText.Text;

                localCon.Open();
                if (CommonVariables.isUserSignatureExist)
                {
                    Guid userID = new Guid(CommonVariables.userIDSiganture);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[UserSignature] ([UserID],[FontType] ,[SignatureText]) VALUES (@UserID,@FontType,@SignatureText)", localCon);
                    da.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
                    da.InsertCommand.Parameters.Add("@FontType", SqlDbType.VarChar).Value = CommonVariables.signatureFont;
                    da.InsertCommand.Parameters.Add("@SignatureText", SqlDbType.VarChar).Value = CommonVariables.signatureText;
                    int rows =  da.InsertCommand.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Signature inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CommonVariables.signatureFont = "";
                    CommonVariables.signatureText = "";
                    CommonVariables.isUserSignatureExist = false;
                }
                
                localCon.Close();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Validate()
        {
            if (txtSignatureText.Text == "")
            {
                MessageBox.Show("Please enter a text for your signature", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
