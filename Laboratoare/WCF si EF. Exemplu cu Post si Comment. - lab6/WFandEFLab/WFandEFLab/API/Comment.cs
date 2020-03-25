using System.Linq;
using System.Data.Entity;
using WFandEFLab;
namespace PostComment
{
    public partial class Comment
    {
        public bool AddComment()
        {
            using (ModelDesignContainer ctx = new ModelDesignContainer())
            {
                bool bResult = false;
                if (this == null || this.postPostId == 0)
                    return bResult;
                if (this.commentId == 0)
                {
                    ctx.Entry<Comment>(this).State = EntityState.Added;
                    Post p = ctx.Posts.Find(this.postPostId);
                    ctx.Entry<Post>(p).State = EntityState.Unchanged;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Comment UpdateComment(Comment newComment)
        {
            using (ModelDesignContainer ctx = new ModelDesignContainer())
            {
                Comment oldComment = ctx.Comments.Find(newComment.commentId);
                // Deoarece parametrul este un Comment ar trebui verificata fiecare
                // proprietate din newComment daca are valoare atribuita si
                // daca valoarea este diferita de cea din bd.
                // Acest lucru il fac numai la modificarea asocierii.
                if (newComment.text != null)
                    oldComment.text = newComment.text;
                if ((oldComment.postPostId != newComment.postPostId)
               && (newComment.postPostId != 0))
                {
                    oldComment.postPostId = newComment.postPostId;
                }
                ctx.SaveChanges();
                return oldComment;
            }
        }
        public Comment GetCommentById(int id)
        {
            using (ModelDesignContainer ctx = new ModelDesignContainer())
            {
                var items = from c in ctx.Comments where (c.CommentId == id) select c;
                return items.Include(p => p.Post).SingleOrDefault();
            }
        }
    }
}