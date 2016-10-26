using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInjectionMVC.Repository.Interfaces;
using DependencyInjectionMVC.Models;

namespace DependencyInjectionMVC.Repository
{
    public class EntityVideoRepository : IVideoRepository
    {
        public bool Create(VideoFileModel video)
        {

            return true;
        }

        public bool Update(VideoFileModel video, int recordID)
        {

            return true;
        }

        public bool Delete(int id)
        {

            return true;
        }

        public int Exists(string videoFileName)
        {

            return 0;
        }

        public VideoFileModel Get(int id)
        {

            return null;
        }

        public VideoFileModel Get(string videoFileName)
        {

            return null;
        }

        public List<VideoFileModel> GetAll(int userID)
        {
            return null;
        }

    }
}