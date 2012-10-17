using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint;
using System.Web.UI.WebControls;

namespace SP2010.Controls.AttachmentField
{
    public class SPAttachmentFieldEditor : UserControl, IFieldEditor
    {
        protected TextBox txtListType;
        protected TextBox txtIsExist;
        protected CustomValidator checkLibrary;
        protected CustomValidator checkExists;
        public bool DisplayAsNewSection
        {
            get { return false; }
        }

        public void InitializeWithField(Microsoft.SharePoint.SPField field)
        {
            txtListType.Text = Convert.ToString((int)SPContext.Current.List.BaseTemplate);
            foreach (SPField fld in SPContext.Current.List.Fields)
                if (fld.TypeAsString.Contains("SPAttachmentField") == true)
                    txtIsExist.Text = "True";

            if (field != null)
                txtIsExist.Text = string.Empty;
        }
        public void OnSaveChange(Microsoft.SharePoint.SPField field, bool isNewField)
        {
        }
        protected void checkLibrary_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            int id = Convert.ToInt32(txtListType.Text);
            switch (id)
            {
                case 101://documnent library
                case 102://survey
                case 103://links
                case 115://form library
                case 109://picture library
                case 119://wiki library
                    e.IsValid = false;
                    break;
                default:
                    e.IsValid = true;
                    break;
            }
        }
        protected void checkExists_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            if (string.Equals(txtIsExist.Text, "True", StringComparison.OrdinalIgnoreCase) == true)
                e.IsValid = false;
            else
                e.IsValid = true;
        }
    }
}
