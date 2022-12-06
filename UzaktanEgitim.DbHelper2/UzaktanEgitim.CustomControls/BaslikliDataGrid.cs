using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UzaktanEgitim.CustomControls
{
    public class BaslikliDataGrid : DataGrid
    {
        //closely coupled grid ile onAutoGeneretingColumn ile çok sıkı bir ilişki var demektir
        //loosely coupled gevşek ilişki var demektir.
        protected override void OnAutoGeneratingColumn(DataGridAutoGeneratingColumnEventArgs e)
        {
            var propDesc = e.PropertyDescriptor as PropertyDescriptor;
            KolonAttribute ka = null;
            for (int i = 0; i < propDesc.Attributes.Count; i++)
            {
                if(propDesc.Attributes[i] is KolonAttribute)
                {
                    ka = propDesc.Attributes[i] as KolonAttribute;
                    break;
                }
            }
            //buraya geldiğiöizde sırada ki property e uygulanan kolon attribute'ü elde etmiş oluyoruz.
            if (ka != null)
            {
                if(!ka.Gorunur)
                    e.Cancel = true;
                if (!string.IsNullOrEmpty(ka.Baslik))
                    e.Column.Header = ka.Baslik;
            }

            base.OnAutoGeneratingColumn(e);
        }
    }
}
