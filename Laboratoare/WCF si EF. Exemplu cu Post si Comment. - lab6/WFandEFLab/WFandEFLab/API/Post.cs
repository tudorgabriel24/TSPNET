using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using WFandEFLab;

namespace PostComment
{
    public partial class Post
    {
        private int postId;

        public bool AddPost()
        {
            using (ModelDesignContainer ctx = new ModelDesignContainer())
            {
                bool bResult = false;
                if (this.postId == 0)
                {
                    var it = ctx.Entry<Post>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
        public Post UpdatePost(Post newPost)
        {
            using (ModelDesignContainer ctx = new ModelDesignContainer())
            {
                Post oldPost = ctx.Posts.Find(newPost.postId);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.description = newPost.description;
                oldPost.domain = newPost.domain;
                oldPost.date = newPost.date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public int DeletePost(int id)
        {
            using (ModelDesignContainer ctx = new ModelDesignContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid =
               @p0", id);
            }
        }
        public Post GetPostById(int id)
        {
            using (ModelDesignContainer ctx = new ModelDesignContainer())
            {
                var items = from p in ctx.Posts where (p.postId == id) select p;
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null; // trebuie verificat in apelant
            }
        }
        public List<Post> GetAllPosts()
        {
            using (ModelDesignContainer ctx = new ModelDesignContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
                // Obligatoriu de verificat in apelant rezultatul primit.
            }
        }
    }
}