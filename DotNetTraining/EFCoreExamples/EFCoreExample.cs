using DotNetTrainingBatch3.ConsoleApp.Models;
using DotNetTrainingBatch3.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.ConsoleApp.EFCoreExamples
{
    public class EFCoreExample
    {
        public void Read()
        {
            AddDbContext db = new AddDbContext();
            List<BlogModel> lst = db.Blogs.ToList();
            foreach (BlogModel item in lst)
            {
                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent);
            }
        }
        public void Edit(int id)
        {
            AddDbContext db = new AddDbContext();
            BlogModel item = db.Blogs.FirstOrDefault(item => item.BlogId == id);
            {
                if (item is null)
                {
                    Console.WriteLine("No data found.");
                    return;
                }

                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent);
            }
        }

        public void Create(string title, string author, string content)
        {
            BlogModel blog = new BlogModel()
            {
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };

            AddDbContext db = new AddDbContext();
            db.Blogs.Add(blog);
            int result = db.SaveChanges();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";

            Console.WriteLine(message);

        }
        public void Update(int id, string title, string author, string content)
        {
            AddDbContext db = new AddDbContext();

            BlogModel item = db.Blogs.FirstOrDefault(item => item.BlogId == id);
            
            if (item is null)
            {
                    Console.WriteLine("No data found.");
                    return;
            }

            item.BlogTitle = title;
            item.BlogAuthor = author;
            item.BlogContent = content;

            int result = db.SaveChanges();

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";

            Console.WriteLine(message);
            }
        public void Delete(int id)
        {
            AddDbContext db = new AddDbContext();

            BlogModel item = db.Blogs.FirstOrDefault(item => item.BlogId == id);

            if (item is null)
            {
                Console.WriteLine("No data found.");
                return;
            }
            db.Blogs.Remove(item);
            int result = db.SaveChanges();

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";

            Console.WriteLine(message);
        }
    }

    }

