﻿using Microsoft.EntityFrameworkCore;
using TbdMinimalMusicAPi.Data;
using TbdMinimalMusicAPi.Models;

namespace TbdMinimalMusicAPi.Repositories
{
    public class TbdRepository:ITbdRepository
    {
        private readonly TbdContext _context;



        public TbdRepository(TbdContext context)
        {
            _context = context;
        }

        // This method adds artists to a user.
        public void AddArtists(int userId, List<Artist> artistsToAdd)
        {
            
            try
            {
                var user = _context.Users
                    .Include(u => u.Artists)
                    .FirstOrDefault(u => u.UserId == userId);
                foreach (var artistToAdd in artistsToAdd)
                {
                    user.Artists.Add(artistToAdd);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding artists: {ex}");
            }
        }

        public void AddGenres(List<Genre> genres, int userId, int artistId)
        {
            throw new NotImplementedException();
        }

        public void AddSongs(List<Song> songs, int artistId, int userId, int genreId)
        {
            throw new NotImplementedException();
        }

        public User Adduser(User user)
        {
            throw new NotImplementedException();
        }

        public bool AtristExists(int artistId)
        {
            throw new NotImplementedException();
        }

        public bool GenreExists(int genreId)
        {
            throw new NotImplementedException();
        }

        public List<Artist> GetArtists(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetGenres(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRelated(int artistId)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongs(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool UserExists(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
