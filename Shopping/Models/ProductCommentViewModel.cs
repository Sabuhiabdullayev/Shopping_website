namespace Shopping.Areas.Member.Models
{
    public class ProductCommentViewModel
    {
        public string CommentOwnerName { get; set; }
        public string ProductCommentContent { get; set; }
        public string ProductCommentEmail { get; set; }
        public int ProductId { get; set; }
    }
}
