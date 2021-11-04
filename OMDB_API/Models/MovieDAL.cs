using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OMDB_API.Models
{
    public class MovieDAL
    {
        public MovieModel GetMovie(string title)
        {
            string url = $"http://www.omdbapi.com/?apikey=1a79d3d5&type=movie&t={title}";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON);

            return result;
        }

        /*public List<MovieModel> GetMoviesByGenre(string genre)
        {

        }*/
    }
}
