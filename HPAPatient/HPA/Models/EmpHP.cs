using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HPA.Models
{
    public class EmpHP
    {
        [DisplayName("1.身分證字號")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[A-Za-z][1-28-9][0-9]{8}$", ErrorMessage = "請重新輸入")]
        //[RegularExpression("^[0-9]{4}[0-1][0-9][0-3][0-9]$", ErrorMessage ="請重新輸入")]
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
        [RegularExpression("^[1-9][0-9]$|^[1][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string waist_circumference{ get; set; }   
        
        [DisplayName("6.收縮壓(mm/Hg)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[5-9][0-9]$|^[1-2][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string systolic_blood_pressure { get; set; }        
        
        [DisplayName("7.膽固醇(mg/dl)")]
        [RegularExpression("^[0-9][0-9]$|^[1-5][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string total_cholesterol { get; set; }
        
        [DisplayName("8.高密度膽固醇(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-2][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string hdl_cholesterol { get; set; }
        
        [DisplayName("9.低密度膽固醇(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-5][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string ldl_cholesterol { get; set; }
        
        [DisplayName("10.三酸甘油酯(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-5][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string triglycerides { get; set; }
        
        [DisplayName("11.空腹血糖(mg/dl)")]
        [Required(ErrorMessage = "請輸入")]
        [RegularExpression("^[0-9][0-9]$|^[1-3][0-9][0-9]$", ErrorMessage = "請重新輸入")]
        public string fasting_plasma_glucose { get; set;}
        
        [DisplayName("12.糖尿病")]
        public string diabetes { get; set; }
        
        [DisplayName("13.高血壓")]
        public string hypertension { get; set; }
        
        [DisplayName("14.抽菸")]
        [Required(ErrorMessage = "請輸入")]
        public string smoking { get; set; }
    }
}
