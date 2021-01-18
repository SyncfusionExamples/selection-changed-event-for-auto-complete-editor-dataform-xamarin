using Syncfusion.SfAutoComplete.XForms;
using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DataFormXamarin
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        DataFormViewModel DataFormViewModel;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.DataObject = new ContactsInfo();
            DataFormViewModel = new DataFormViewModel();
            dataForm.SourceProvider = new SourceProviderExt();
            dataForm.RegisterEditor("AutoComplete", new CustomAutoCompleteEditor(dataForm));
            dataForm.RegisterEditor("City", "AutoComplete");
        }
    }
}
