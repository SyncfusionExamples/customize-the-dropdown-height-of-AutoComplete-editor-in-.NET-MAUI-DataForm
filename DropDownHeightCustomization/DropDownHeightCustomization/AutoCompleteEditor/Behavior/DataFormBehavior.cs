using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DropDownHeightCustomization
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.ItemsSourceProvider = new ItemSourceProvider();
            dataForm.RegisterEditor("Address", DataFormEditorType.MultilineText);
            dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
            dataForm.RegisterEditor("City", DataFormEditorType.ComboBox);
            dataForm.GenerateDataFormItem += OnGenerateDataItem;
        }
        private void OnGenerateDataItem(object? sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null && e.DataFormItem is DataFormAutoCompleteItem autoComplete)
            {
                autoComplete.MaxDropDownHeight = 90;
            }
        }
        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
            if (dataForm != null)
            {
                dataForm.GenerateDataFormItem -= this.OnGenerateDataItem;
            }
        }
    }
}