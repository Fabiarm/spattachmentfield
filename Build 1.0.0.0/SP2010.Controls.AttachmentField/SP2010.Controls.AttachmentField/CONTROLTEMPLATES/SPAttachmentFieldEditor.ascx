<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls"
    Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="wssuc" TagName="InputFormControl" Src="~/_controltemplates/InputFormControl.ascx" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Control Language="C#" Inherits="SP2010.Controls.AttachmentField.SPAttachmentFieldEditor, SP2010.Controls.AttachmentField, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d16d4fa4411244c6" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages"
    Assembly="Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<wssuc:InputFormControl runat="server" LabelText="<%$Resources:SPAttachmentField,FieldType_Editor_InputForm_LabelText%>">
    <Template_Control>
        <div><asp:Literal ID="ltlDesc" runat="server" Text="<%$Resources:SPAttachmentField,FieldType_Editor_Description%>" /></div><br />
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <asp:CustomValidator ID="checkLibrary" runat="server" Display="Dynamic" EnableClientScript="true" ControlToValidate="txtListType"
                        ErrorMessage="<%$Resources:SPAttachmentField,FieldType_Editor_CheckLibrary_Validation%>"
                        OnServerValidate="checkLibrary_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CustomValidator ID="checkExists" runat="server" Display="Dynamic" EnableClientScript="true" ControlToValidate="txtIsExist"
                        ErrorMessage="<%$Resources:SPAttachmentField,FieldType_Editor_CheckExists_Validation%>" OnServerValidate="checkExists_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
        </table>
        <asp:TextBox ID="txtListType" runat="server" Enabled="false" Visible="false"></asp:TextBox>
        <asp:TextBox ID="txtIsExist" runat="server" Enabled="false" Visible="false"></asp:TextBox>
    </Template_Control>
</wssuc:InputFormControl>
