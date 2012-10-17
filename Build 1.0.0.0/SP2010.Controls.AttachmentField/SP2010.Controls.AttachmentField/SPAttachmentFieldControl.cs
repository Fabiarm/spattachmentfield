using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.WebControls;
using System.Web.UI.WebControls;
using Microsoft.SharePoint;

namespace SP2010.Controls.AttachmentField
{
    public class SPAttachmentFieldControl: BaseFieldControl
    {
        protected override string DefaultTemplateName
        {
            get
            {
                if (this.ControlMode == SPControlMode.Display)
                    return "SPAttachFieldForDisplay";
                if (this.ControlMode == SPControlMode.Edit || this.ControlMode == SPControlMode.New)
                    return "SPAttachFieldForEdit";
                return base.DefaultTemplateName;
            }
        }
        public override string DisplayTemplateName
        {
            get
            {

                return "SPAttachFieldForDisplay";
            }
            set
            {
                base.DisplayTemplateName = value;
            }
        }
    }
}
