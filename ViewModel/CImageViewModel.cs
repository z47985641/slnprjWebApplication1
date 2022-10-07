using Microsoft.AspNetCore.Http;
using ProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectMVC.ViewModel
{
    public class CImageViewModel
    {
        private Image _Image;
        public int ImageId
        {
            get { return _Image.ImageId; }
            set { _Image.ImageId = value; }
        }
        public CImageViewModel()
        {
            _Image = new Image();
        }
        public string ImagePath
        {
            get { return _Image.ImagePath; }
            set { _Image.ImagePath = value; }
        }
        public string ImageCaption
        {
            get { return _Image.ImageCaption; }
            set { _Image.ImageCaption = value; }
        }
        public IFormFile photo { get; set; }
    }
}

