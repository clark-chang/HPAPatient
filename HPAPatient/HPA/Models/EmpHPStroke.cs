using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HPA.Models
{
    public class EmpHPStroke
    {
        [DisplayName("1.識別號")]
        [Required(ErrorMessage="請輸入")]
        [RegularExpression("^[0-9]{4}[0-1][0-9][0-3][0-9]$", ErrorMessage ="請重新輸入")]
        public string emp_specialid { get; set; }
        
        [DisplayName("2.性別")]
        [Required(ErrorMessage = "請輸入")]        
        public string emp_sex { get; set; }
        
        [DisplayName("3.身高(公分)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[1-2][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string height { get; set;}
        
        [DisplayName("4.體重(公斤)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[3-9][0-9]$|^[1-2][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string weight { get; set; }
        
        [DisplayName("5.收縮壓(mm/Hg)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[5-9][0-9]$|^[1-2][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string systolic_blood_pressure { get; set; }

        [DisplayName("6.膽固醇(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-5][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string total_cholesterol { get; set; }

        [DisplayName("7.三酸甘油酯(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-5][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string triglycerides { get; set; }
        
        [DisplayName("8.空腹血糖(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-3][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string fasting_plasma_glucose { get; set;}
    }
}
