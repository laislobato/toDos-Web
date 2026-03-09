namespace ToDoPlataform.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "E-mail", Prompt = "seu@email.com")]
        [Required(ErrorMessage = "O e-mail de acesso é obrigatório")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}