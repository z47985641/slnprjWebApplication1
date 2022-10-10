﻿using prjWebApplication1.Models;

namespace prjWebApplication1.ViewModels
{
    public class CommentViewModel
    {
        private Comment _comment;
        public Comment comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public CommentViewModel() {
            _comment = new Comment();
        }
        public string txtKey { get; set; }
        public int Id { 
            get { return _comment.CommentId; }
            set { _comment.CommentId = value; }
        }
        public string CommentDetail
        {
            get { return _comment.CommentDetail; }
            set { _comment.CommentDetail = value; }
        }
        public int CommentPoint
        {
            get { return (int)_comment.CommentPoint; }
            set { _comment.CommentPoint = value; }
        }
        public int RoomId
        {
            get { return _comment.RoomId; }
            set { _comment.RoomId = value; }
        }
    }
}
