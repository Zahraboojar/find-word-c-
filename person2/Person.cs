using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    public class Person
    {
        [DvgDisplayName(displayName:"نام")]
        [Required]
        public string Name { get; set; }
        [DvgDisplayName(displayName: "نام خانوادگی")]
        [Required]
        public string Family { get; set; }
        [NationalCodeValidation]
        public string National_code { get; set; }
        public Gender Gender { get; set; }
        public int Id { get; set; }

        public virtual string FullName()
        {
            return $"{Name} {Family}";
        }
        public OperationResult ValidateTextBox(TextBox textBox)
        {
            if (textBox.Text == "")
                return OperationResult.Failed("فیلد "+textBox.Name + " خالی است ");
            else
                return OperationResult.Success();
        }
        public OperationResult IsSelected(DataGridView dgv)
        {
            if (dgv.CurrentCell == null)
                return OperationResult.Failed("هیچ سلولی انتخاب نشده. ابتدا انتخاب کنید");
            else
                return OperationResult.Success();
        }
    }
}
