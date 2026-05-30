namespace LibraryAPI.Models
{
    public class Borrowing
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}