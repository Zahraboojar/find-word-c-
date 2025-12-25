using System.Reflection;
using System.Windows.Forms;

namespace person2
{
    internal static class DvgExtention
    {
        public static void BindColumns<T>(this DataGridView dvg)
        {
            dvg.AutoGenerateColumns = false;
            dvg.Columns.Clear();

            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var attr = property.GetCustomAttribute<DvgDisplayNameAttribute>();

                dvg.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = property.Name,
                    HeaderText = attr != null ? attr.DisplayName : property.Name,
                    Name = property.Name,
                    Visible = property != null
                });
            }
        }

    }
}
