using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionMVC.Models;

namespace DependencyInjectionMVC.Repository.Interfaces
{
    public interface IVideoRepository
    {
        bool Create(VideoFileModel video);
        bool Update(VideoFileModel video, int recordID);
        bool Delete(int id);
        int Exists(string videoFileName);
        VideoFileModel Get(int id);
        VideoFileModel Get(string videoFileName);
        List<VideoFileModel> GetAll(int userID);
    }
}
