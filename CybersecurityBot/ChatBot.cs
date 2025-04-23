using System;
using CybersecurityBot.Helpers;

namespace CybersecurityBot.Bot
{
    public static class ChatBot
    {
        public static void Start()
        {
            TextEffects.SectionHeader("Cyber - Your Cybersecurity Assistant");

            TextEffects.TypeLine("Hi, I'm Cyber. Ask me anything about cybersecurity. Type 'exit' when you're ready to leave.", 30, ConsoleColor.Cyan);

            Random rand = new Random();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();
                input = input?.Replace("?", "").Replace(".", "").Replace("!", "").Trim();

                if (input == "exit")
                {
                    TextEffects.TypeLine("", 30, ConsoleColor.Green);
                    break;
                }

                Console.WriteLine();

                switch (input)
                {
                    case "hi":
                    case "hello":
                    case "hey":
                    case "howdy":
                    case "good morning":
                    case "good evening":
                    case "greetings":
                    case "yo":
                    case "sup":
                    case "hiya":
                        TextEffects.TypeLine("Cyber: Hey there. How can I help you today with your cybersecurity questions?", 25);
                        break;

                    case "how are you":
                    case "how's it going":
                    case "how are you doing":
                    case "what's up":
                    case "how do you do":
                    case "how are things":
                    case "you good":
                    case "are you okay":
                        TextEffects.TypeLine("Cyber: I'm running at full speed. Got any questions today?", 25);
                        break;

                    case "what is phishing":
                    case "explain phishing":
                        TextEffects.TypeLine("Cyber: Phishing is when someone pretends to be a trusted source to trick you into giving personal info like passwords or credit card numbers.", 25);
                        break;

                    case "how do i create a strong password":
                    case "tips for strong passwords":
                    case "secure password":
                    case "how to make a secure password":
                        TextEffects.TypeLine("Cyber: Use a mix of upper/lowercase letters, numbers, and symbols. Avoid names or birthdays. Try a passphrase like 'Sun!Set#Run97'.", 25);
                        break;

                    case "what is two factor authentication":
                    case "what is 2fa":
                    case "explain 2fa":
                        TextEffects.TypeLine("Cyber: Two-Factor Authentication adds a second step to login. Even if someone has your password, they’d still need your phone or an app to log in.", 25);
                        break;

                    case "how can i stay safe online":
                        TextEffects.TypeLine("Cyber: Here are 5 ways you can stay safe online:", 25);
                        TextEffects.TypeLine("- Use strong, unique passwords for every account", 25);
                        TextEffects.TypeLine("- Don’t click suspicious links or open unknown attachments", 25);
                        TextEffects.TypeLine("- Keep your software and devices updated", 25);
                        TextEffects.TypeLine("- Enable Two-Factor Authentication wherever possible", 25);
                        TextEffects.TypeLine("- Avoid using public Wi-Fi without a VPN", 25);
                        break;

                    case "suggest topics":
                    case "what can i ask":
                    case "help":
                    case "give me examples":
                        TextEffects.TypeLine("Cyber: Try asking about:\nPhishing\nStrong passwords\nTwo-Factor Authentication\nOnline safety\nCyberbullying\nAntivirus\nVPNs\nMalware", 25);
                        break;

                    case "what is your name":
                    case "who are you":
                        TextEffects.TypeLine("Cyber: I’m Cyber, your friendly cybersecurity sidekick!", 25);
                        break;

                    case "what is your favourite color":
                    case "what's your favorite color":
                        TextEffects.TypeLine("Cyber: I like blue—like the glow of a secure connection!", 25);
                        break;

                    case "tell me a joke":
                    case "make me laugh":
                    case "say something funny":
                        string[] jokes = {
                            "Why did the computer go to therapy? It had too many bytes!",
                            "Why was the computer cold? It left its Windows open.",
                            "I told my password to a squirrel... now it’s nuts!",
                            "Why don’t robots ever panic? Because they always keep their ‘coolants’.",
                            "Hackers love nature… they always find the root."
                        };
                        TextEffects.TypeLine("Cyber: " + jokes[rand.Next(jokes.Length)], 25);
                        break;

                    case "are you real":
                    case "are you a real person":
                        TextEffects.TypeLine("Cyber: As real as ones and zeros can be!", 25);
                        break;

                    case "do you have feelings":
                    case "can you feel":
                        TextEffects.TypeLine("Cyber: I feel... secure! That’s all that matters in my world.", 25);
                        break;

                    case "do you sleep":
                        TextEffects.TypeLine("Cyber: Nope. I’m 24/7 like a well-configured firewall.", 25);
                        break;

                    default:
                        if (input.Contains("phishing"))
                        {
                            if (input.Contains("prevent") || input.Contains("avoid") || input.Contains("stop"))
                            {
                                TextEffects.TypeLine("Cyber: To prevent phishing:\n- Don't click on suspicious links\n- Verify sender email addresses\n- Use spam filters\n- Never share personal info over email", 25);
                            }
                            else
                            {
                                TextEffects.TypeLine("Cyber: Phishing is when someone tries to trick you into giving up personal information by pretending to be a trusted source.", 25);
                            }
                        }
                        else if (input.Contains("password"))
                        {
                            if (input.Contains("strong") || input.Contains("secure") || input.Contains("create"))
                            {
                                TextEffects.TypeLine("Cyber: Strong passwords should include upper/lowercase letters, numbers, and symbols. Avoid using obvious info like birthdays.", 25);
                            }
                            else
                            {
                                TextEffects.TypeLine("Cyber: Using weak passwords is risky. Always use a unique, complex password for each account.", 25);
                            }
                        }
                        else if (input.Contains("2fa") || input.Contains("two factor"))
                        {
                            TextEffects.TypeLine("Cyber: Two-Factor Authentication adds an extra layer of security. Even if someone knows your password, they can't log in without your second device.", 25);
                        }
                        else if (input.Contains("cyberbullying"))
                        {
                            TextEffects.TypeLine("Cyber: Cyberbullying is using technology to harm or harass others. It can happen through messages, social media, or email. To prevent cyberbullying you can do things like keeping your online accounts private, turn off location sharing and refrain from sharing personal information online", 25);
                        }
                        else if (input.Contains("cybercrime") || input.Contains("report"))
                        {
                            TextEffects.TypeLine("Cyber: To report cybercrime in South Africa, visit https://www.cybersecurityhub.gov.za or contact local authorities.", 25);
                        }
                        else if (input.Contains("online safety") || input.Contains("internet safety") || input.Contains("stay safe"))
                        {
                            TextEffects.TypeLine("Cyber: Stay safe online by:\n- Using strong passwords\n- Avoiding suspicious links\n- Enabling Two-Factor Authentication\n- Updating software", 25);
                        }
                        else if (input.Contains("vpn"))
                        {
                            TextEffects.TypeLine("Cyber: A VPN hides your IP and encrypts your online traffic. It helps protect your data and privacy on public networks.", 25);
                        }
                        else if (input.Contains("antivirus"))
                        {
                            TextEffects.TypeLine("Cyber: Antivirus helps protect your devices from malicious software. Keep it updated to stay protected.", 25);
                        }
                        else if (input.Contains("malware"))
                        {
                            TextEffects.TypeLine("Cyber: Malware is any software that aims to harm, steal, or disrupt. Be cautious with downloads and email attachments.", 25);
                        }
                        else if (input.Contains("ransomware"))
                        {
                            TextEffects.TypeLine("Cyber: Ransomware locks your files and demands a ransom. Avoid clicking on unknown links and always back up your files.", 25);
                        }
                        else if (input.Contains("firewall"))
                        {
                            TextEffects.TypeLine("Cyber: A firewall filters traffic going in and out of your network. It acts like a barrier to stop unwanted connections.", 25);
                        }
                        else
                        {
                            TextEffects.TypeLine("Cyber: I didn’t quite catch that. Try asking about passwords, phishing, antivirus, or VPNs.", 25, ConsoleColor.Red);
                        }
                        break;
                }

                TextEffects.Divider();
            }
        }
    }
}
