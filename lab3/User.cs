namespace lab3 {
    public class User : Client {
        public string StoredPassword { get; set; }


        public User() {
            Description = "Base-Level User";
        }

        public string PasswordHash(string password) {
            return password;
        }

    }
}
