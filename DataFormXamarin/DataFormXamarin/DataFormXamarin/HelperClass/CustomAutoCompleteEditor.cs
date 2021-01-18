using Syncfusion.SfAutoComplete.XForms;
using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class CustomAutoCompleteEditor : DataFormAutoCompleteEditor
     {
        SfAutoComplete autoComplete;
        public CustomAutoCompleteEditor(SfDataForm dataForm) : base(dataForm)
        {
        }
        protected override SfAutoComplete OnCreateEditorView(DataFormItem dataFormItem)
        {
            autoComplete = new SfAutoComplete();
            return autoComplete;
        }
        protected override void OnWireEvents(SfAutoComplete view)
        {
            base.OnWireEvents(view);
            autoComplete.SelectionChanged += AutoComplete_SelectionChanged;
        }
        protected override void OnUnWireEvents(SfAutoComplete view)
        {
            base.OnUnWireEvents(view);
            autoComplete.SelectionChanged -= AutoComplete_SelectionChanged;
        }
        private void AutoComplete_SelectionChanged(object sender, Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("", "Selection Changed", "ok");
        }
        protected override void OnInitializeView(DataFormItem dataFormItem, SfAutoComplete view)
        {
            base.OnInitializeView(dataFormItem, view);
        }
    }
}
