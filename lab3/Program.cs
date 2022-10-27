using lab3;

public class Program {
    public static void Main() {
        User user = new User();
        SecuritSystem securitSystem = new SecuritSystem();
        securitSystem.TwoFactorAuthentication = true;
        securitSystem.IsAdmin = true;

        if (securitSystem.TwoFactorAuthentication == null && securitSystem.TwoFactorRequired) {
            throw new Exception();
        }

        if (securitSystem.TwoFactorAuthentication && !securitSystem.IsAdmin) {
            user = new AuthroziedUser();
        } else if(securitSystem.TwoFactorAuthentication && securitSystem.IsAdmin) {
            user = new Administrator();
        }
    }
}
