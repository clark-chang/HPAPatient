using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HPA.Models
{
    public class EmpHPHypertension
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

        [DisplayName("6.收縮壓(mm/Hg)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[5-9][0-9]$|^[1-2][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string systolic_blood_pressure { get; set; }   

        [DisplayName("8.高密度膽固醇(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-2][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string hdl_cholesterol { get; set; }
        
        [DisplayName("9.低密度膽固醇(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-5][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string ldl_cholesterol { get; set; }
    }
}
