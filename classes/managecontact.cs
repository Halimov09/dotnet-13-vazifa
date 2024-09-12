using System.Reflection.Metadata;

namespace CONTACT.classes
{
    public class Managecontact
    {
        static string faylPath = "contacts.txt";
        public static void QoShish(string name, long number)
        {
        var kontakt = new Addcontact(name, number);
        File.AppendAllText(faylPath, kontakt.ToString() + Environment.NewLine);
        Console.WriteLine("Kontakt qo'shildi!");
        }
        
        public static void KoRish()
        {
            if (File.Exists(faylPath))
            {
                string[] contacts = File.ReadAllLines(faylPath);
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine("Kontaktlar mavjud emas.");
            }
        }

        public static void Tahrirlash (string oldName, string newName, long newNumber)
        {
            string [] contacts = File.ReadAllLines(faylPath);
            bool choise = false;

            for (int i = 0; i < contacts.Length; i++)

            {
                if (contacts[i].StartsWith(oldName + ","))
                {
                    contacts[i] = $"{newName}, {newNumber}";
                    choise = true;
                }


            }

            if (choise)
            {
                File.WriteAllLines(faylPath, contacts);
                Console.WriteLine("Kontakt tahrirlandi!");
            }else
            {
                Console.WriteLine("Kontakt topilmadi.");
            }
        }

        public static void OChirish(string ism)
        {
            string[] contacts = File.ReadAllLines(faylPath);
            string[] yangilanganContacts = contacts.Where(c => !c.StartsWith(ism + ",")).ToArray();

            if (contacts.Length != yangilanganContacts.Length)
            {
                File.WriteAllLines(faylPath, yangilanganContacts);
                Console.WriteLine("Kontakt o'chirildi!");
            }
            else
            {
                Console.WriteLine("Kontakt topilmadi.");
            }
        }
    }
}