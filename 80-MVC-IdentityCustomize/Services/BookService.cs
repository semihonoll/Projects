using _80_MVC_IdentityCustomize.Contexts;
using _80_MVC_IdentityCustomize.Models;
using _80_MVC_IdentityCustomize.Models.Enums;
using _80_MVC_IdentityCustomize.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace _80_MVC_IdentityCustomize.Services
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BookService(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<BookListVM>> GetUserBookAsync(string userId)
        {
            return await _context.Books
                .Where(b => b.AppUserId == userId).Select(x => new BookListVM { Title = x.Title, Author = x.Author, Status = x.Status, CreatedDate = x.CreatedDate })
                .ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Books
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Book>> GetBookByNameAsync(string bookName)
        {
            return await _context.Books
                .Where(x => x.Title.Contains(bookName))
                .ToListAsync();
        }

        public async Task<List<Book>> GetBookByStatus(Status status)
        {
            return await _context.Books
                .Where(x => x.Status == status)
                .ToListAsync();
        }

        public bool AddBook(BookCreateVM book, string userId)
        {
            var result = new Book() 
            { 
                AppUserId = userId,
                Title = book.Title,
                Author = book.Author,
                Status = book.Status,
            };
            _context.Books.Add(result);
            return _context.SaveChanges() > 0;
        }

        public bool UpdateBook(Book book)
        {
            _context.Books.Update(book);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var book = _context.Books.Find(id);
            if (book is not null)
            {
                _context.Books.Remove(book);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public async Task<bool> BookExistAsync(int id)
        {
            return await _context.Books.AnyAsync(e => e.Id == id);
        }
    }
}
