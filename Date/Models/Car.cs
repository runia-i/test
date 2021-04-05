using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Models
{
    public class Car
    {
        public int id { set; get; }   //ид

        public string name { set; get; } //имя

        public string shortDesk { set; get; } //короткое описание

        public string longDesk { set; get; } //длинное описание
         
        public string img { set; get; } //url картинки

        public ushort price { set; get; } //цена. короткая и положительная

        public bool isFavourite { set; get; } //отображается ли товар на главной

        public bool available { set; get; } //есть ли на складе и сколько

        public int categotyID { set; get; } 

        public virtual Category Category { set; get; }
    }
}
