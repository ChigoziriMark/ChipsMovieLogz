using ChipsMovieLogz.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChipsMovieLogz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChipsMovieController : ControllerBase
    {
        private readonly ILogger<ChipsMovieController> _logger;

        public ChipsMovieController(ILogger<ChipsMovieController> logger)
        {
            _logger = logger;
        }
        [HttpGet("movies", Name = "GetMovie")]
        public IEnumerable<Models.Movie> Get(string? title, string? genre, DateTime releaseDate, string? about, int imdbRating, int motionPictureRating, int metaScore, string? director, string? writer, int runtime, string? topCast)
        {
            var returnData = new RetrieveMovies("DataSource");
            var syncedItemHistory = returnData.GetSyncedMovies(title, genre, releaseDate, about, imdbRating, motionPictureRating, metaScore, director, writer, runtime, topCast);
            return syncedItemHistory;
        }


    }

}