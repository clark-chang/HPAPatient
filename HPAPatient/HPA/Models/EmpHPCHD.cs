using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HPA.Models
{
    public class EmpHPCHD
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
        
        [DisplayName("5.腰圍(公分)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[1-9][0-9]$|^[1][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string waist_circumference{ get; set; }  

        [DisplayName("6.高密度膽固醇(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-2][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string hdl_cholesterol { get; set; }

        [DisplayName("7.高血壓")]
        [Required(ErrorMessage = "請輸入")]
        public string hypertension { get; set; }
    }
}
