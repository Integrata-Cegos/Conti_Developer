namespace Javacream.Books{
    public class Book{
        public string Isbn {get;}
        private string _title;
        public string Title{
            get{
            return _title;
            }
            set {
                if (value.Length >= 2){
                    this._title = value;
                }else{
                    throw new Exception("invalid title: " + value);
                }
            }
        }
        private int _pages;
        public int Pages{
            get{
            return _pages;
            }
            set {
                if (value > 0 ){
                    this._pages = value;
                }else{
                    throw new Exception("invalid pages: " + value);
                }
            }
        }

        public bool Available{get; set;}

        private double _price;

        public double Price{
            get {
                return _price;
            }
            set {
                if (value >= 0 ){
                    this._price = value;
                }else{
                    throw new Exception("invalid price: " + value);
                }

            }
        }

        public Book(string isbn, string title, int pages, double price, bool available){
            this.Isbn = isbn;
            this.Title = title;
            this.Pages = pages;
            this.Price = price;
            this.Available = available;
        }

        public virtual string info(){
            return "Book: isbn=" + Isbn + ", title=" + Title + ", pages=" + Pages + ", price=" + Price + ", available=" + Available;
        }
    }

    public class SchoolBook : Book{
        public int Year{get;}
        public string Subject{get;}

        public SchoolBook(string isbn, string title, int pages, double price, bool available, int year, string subject):base(isbn, title, pages, price, available){
            this.Year = year;
            this.Subject = subject;
        }
        public override string info(){
            return base.info() + ", year=" + Year + ", subject=" + Subject;
        }

    }

    public class SpecialistBook : Book{
        public string Topic{get;}

        public SpecialistBook(string isbn, string title, int pages, double price, bool available, string topic):base(isbn, title, pages, price, available){
            this.Topic = topic;
        }
        public override string info(){
            return base.info() + ", topic=" + Topic;
        }

    }

}