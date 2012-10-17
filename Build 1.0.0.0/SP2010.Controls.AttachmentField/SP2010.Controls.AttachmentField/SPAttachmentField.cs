using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using Microsoft.SharePoint.Security;
using System.Security.Permissions;

namespace SP2010.Controls.AttachmentField
{
    public class SPAttachmentField : SPFieldText
    {
        public SPAttachmentField(SPFieldCollection fields, string fName)
            : base(fields, fName)
        {
        }
        public SPAttachmentField(SPFieldCollection fields, string tName, string dName)
            : base(fields, tName, dName)
        {
        }

        public override BaseFieldControl FieldRenderingControl
        {
            [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
            get
            {
                SPAttachmentFieldControl fieldControl = new SPAttachmentFieldControl();
                fieldControl.FieldName = this.InternalName;
                return fieldControl;
            }
        }
        public override string GetFieldValueAsHtml(object value)
        {
            return base.GetFieldValueAsHtml(value);
        }
        public override string GetFieldValueAsText(object value)
        {
            return base.GetFieldValueAsText(value);
        }
    }
}
