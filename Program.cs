using CONTACT.classes;

try
{
    while (true)
{
    Console.WriteLine("1. Yangi kontakt qo'shish");
    Console.WriteLine("2. Kontaktlarni ko'rish");
    Console.WriteLine("3. Kontakt tahrirlash");
    Console.WriteLine("4. Kontakt o'chirish");
    Console.WriteLine("5. Chiqish");
    Console.Write("Raqamlarni birini tanlang: ");
    string tanlov = Console.ReadLine();

    switch (tanlov)
    {
        case "1":
            QoShish();
            break;
        case "2":
            Managecontact.KoRish();
            break;
        case "3":
            Tahrirlash();
            break;
        case "4":
            OChirish();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Noto'g'ri tanlov.");
            break;
    }
}

static void QoShish()
{
    Console.WriteLine("Foydalanuvchi ismini kiriting: ");
    string name = Console.ReadLine();
    Console.WriteLine("Foydalanuvchi raqamini kiriting: ");
    long number =   long.Parse(Console.ReadLine());

    Managecontact.QoShish(name, number);
};


static void Tahrirlash()
{
    Console.Write("Tahrir qilish uchun kontakt ismni kiriting: ");
    string oldName = Console.ReadLine();
    
    Console.WriteLine("Yangi foydalanuvchi ismini kiriting: ");
    string newName = Console.ReadLine();
    Console.WriteLine("Yangi foydalanuvchi raqamini kiriting: ");
    long newNumber =   long.Parse(Console.ReadLine());

    Managecontact.Tahrirlash(oldName, newName, newNumber);
};

static void OChirish()
{
    Console.Write("O'chirish uchun kontakt ismni kiriting: ");
    string ism = Console.ReadLine();
    Managecontact.OChirish(ism);
};
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
finally{
    Console.WriteLine("Dastur yakunlandi");
}