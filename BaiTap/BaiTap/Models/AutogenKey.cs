﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BaiTap.Models
{
    public class AutogenKey
    {
        public string AutogenerateKey (string id, int number)
        {
             string strkey = "";
            // kiểm tra giá trị ID truyền vào là rỗng hay không
            //Nếu ID null
            //tách riêng phần  số và phần chữ của tham số ID
            //Giữ nguyên phần chữ
            //Phần số chuyển đổi sang kiểu số nguyên và tăng lên 1 đơn vị
            //Ghép phần số với phần chữ để được mã tự sinh
            //Trả về mã sau khi tự sinh

            string numPart = "", strPart = "", strPhanso = "";
            numPart = Regex.Match(id, @"\d+").Value;
            strPart = Regex.Match(id, @"\D+").Value;
            int phanso = (Convert.ToInt32(numPart) + 1);
            for (int i = 0; i < numPart.Length - phanso.ToString().Length; i++)
            {
                strPhanso += phanso;
                //tách phần chữ

            }
            strkey = strPart + strPhanso;
            return strkey;
        }

        internal string AutogenerateKey(string personID)
        {
            throw new NotImplementedException();
        }
    }
}