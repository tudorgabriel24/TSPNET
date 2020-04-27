using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameworkProject1.API
{
    public class APIController {
        public void CreateMedia(string type, string place, string path)
        {
            using (DBContainer context = new DBContainer())
            {
                Media media = new Media();
                Random randomId = new Random();
                media.Id = Convert.ToInt32(randomId.Next());
                media.type = type;
                media.place = place;
                media.path = path;
                    context.MediaSet.Add(media);
                    context.SaveChanges();
            }
        }

        public List<string> GetMediaByPersonName(string name, string type)
        {
            using (DBContainer context = new DBContainer())
            {
                List<string> response = new List<string>();
                int personId = context.PersonSet.SingleOrDefault(person => person.name == name).Id;
                List<LinkMediaPerson> references = context.LinkMediaPersonSet.SqlQuery("SELECT * FROM LinkMediaPerson WHERE PersonId=" + personId).ToList();
                foreach (LinkMediaPerson reference in references)
                {
                    Media m = context.MediaSet.SingleOrDefault(searchMedia => searchMedia.Id == reference.MediaId);
                    if(m.type == type)
                    {
                        response.Add(m.path);
                    }
                }

                return response;
            }
        }

        public List<string> GetMediaByLocation(string type, string place)
        {
            string query = "SELECT * FROM Media WHERE type=" + type + " AND place=" + place;

            using (DBContainer context = new DBContainer())
            {
                List<string> response = new List<string>();
                List<Media> media = context.MediaSet.SqlQuery(query).ToList();
                foreach (Media m in media)
                {
                    response.Add(m.path);
                }
                return response;
            }
        }

        public void AddPersonToMedia(string name, string path)
        {
            using (DBContainer context = new DBContainer())
            {
                string query = "SELECT * FROM Media WHERE path=" + path;
                Person foundExistingPerson = context.PersonSet.SingleOrDefault(searchPerson => searchPerson.name == name);
                int personId;
                if (foundExistingPerson != null)
                {
                    personId = foundExistingPerson.Id;
                }
                else
                {
                    Person newPerson = new Person();
                    Random randomId = new Random();
                    newPerson.Id = Convert.ToInt32(randomId.Next());
                    newPerson.name = name;
                    context.PersonSet.Add(newPerson);
                    context.SaveChanges();
                    personId = newPerson.Id;
                }
                Random linkRandomId = new Random();
                LinkMediaPerson reference = new LinkMediaPerson()
                {
                    Id = Convert.ToInt32(linkRandomId.Next()),
                    MediaId = context.MediaSet.SingleOrDefault(searchMedia => searchMedia.path == path).Id,
                    PersonId = personId,
                };
                context.LinkMediaPersonSet.Add(reference);
                context.SaveChanges();
            }
        }

        public void RemoveMedia(string path)
        {
            using (DBContainer context = new DBContainer())
            {
                Media dbMedia = context.MediaSet.SingleOrDefault(searchMedia => searchMedia.path == path);
                string query = "SELECT * FROM LinkMediaPerson WHERE MediaId=" + dbMedia.path;
                List<LinkMediaPerson> dbReferences = context.LinkMediaPersonSet.SqlQuery(query).ToList();
                foreach (LinkMediaPerson reference in dbReferences)
                {
                    context.LinkMediaPersonSet.Remove(reference);
                }
                context.MediaSet.Remove(dbMedia);
                context.SaveChanges();
            }
        }
    }
}
