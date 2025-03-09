using System;
using System.Runtime.InteropServices;

public class ResumeProgram
{
    public static void Main(string[] args)
    {
        int option;

        do
        {
            Console.Clear(); // Limpia la pantalla para cada iteración del menú

            // Cambiar el color de fondo y del texto
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();  // Es necesario limpiar la consola después de cambiar los colores

            Console.WriteLine("====== Main Menu - Resume ======");
            Console.WriteLine("1. Personal Information");
            Console.WriteLine("2. Professional Profile");
            Console.WriteLine("3. Education");
            Console.WriteLine("4. Work Experience");
            Console.WriteLine("5. Personality Traits");
            Console.WriteLine("6. Languages");
            Console.WriteLine("7. Skills");
            Console.WriteLine("8. Featured Projects");
            Console.WriteLine("9. Key Achievements");
            Console.WriteLine("10. References");
            Console.WriteLine("11. Value Proposition");
            Console.WriteLine("12. Exit");
            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        ShowPersonalInformation();
                        break;
                    case 2:
                        ShowProfessionalProfile();
                        break;
                    case 3:
                        ShowEducation();
                        break;
                    case 4:
                        ShowWorkExperience();
                        break;
                    case 5:
                        ShowPersonalityTraits();
                        break;
                    case 6:
                        ShowLanguages();
                        break;
                    case 7:
                        ShowSkills();
                        break;
                    case 8:
                        ShowFeaturedProjects();
                        break;
                    case 9:
                        ShowKeyAchievements();
                        break;
                    case 10:
                        ShowReferences();
                        break;
                    case 11:
                        ShowValueProposition();
                        break;
                    case 12:
                        Console.WriteLine("Thank you for using the Resume Program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            if (option != 12)
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }

        } while (option != 12);
    }

   // Opciones del menú
    public static void ShowPersonalInformation()
    {
        Console.Clear();
        Console.WriteLine("====== Personal Information ======\r\n");
        Console.WriteLine("Name: Alejandro De Mendoza\r\n");
        Console.WriteLine("Age: 41 years old\r\n");
        Console.WriteLine("Email: alejandro.mendoza.techengineer@gmail.com\r\n");
        Console.WriteLine("Phone: +57 311 268 7118");
    }

    public static void ShowProfessionalProfile()
    {
        Console.Clear();
        Console.WriteLine("====== Professional Profile ======\r\n");
        Console.WriteLine("I am a professional in Industrial Engineering and Business Administration, with a degree in Computer Engineering. I specialize in Logistics and have completed a specialization in Artificial Intelligence, along with a Master's Degree in Supply Chain Management.\r\n");
        Console.WriteLine("I am trilingual with IELTS and Portuguese certification, which allows me to function in high-level global environments. I have developed advanced skills in emerging technologies and innovative solutions.\r\n");
        Console.WriteLine("My technical training includes postgraduate studies in programming languages such as: \r\n\r\n-Java,\r\n-SQL, \r\n-PowerShell, \r\n-C++, \r\n-Visual Studio/Azure/Linux/C#, \r\n-Python, \r\n-PHP with solid knowledge in software development, \r\n-Advanced algorithms, and system optimization.");
        Console.WriteLine("-As well as specialized tools for data analysis and visualization such as Power BI, Looker Studio, LaTeX, and TeXStudio.\r\n");
        Console.WriteLine("I have developed advanced skills in emerging technologies and innovative solutions, having a solid understanding of software development, advanced algorithms, and system optimization. \r\n\r\nAdditionally, I am proficient in specialized tools for data analysis and visualization, including Power BI, Looker Studio, LaTeX, and TeXStudio.\r\n");
        Console.WriteLine("These skills allow me to design and develop intelligent systems, optimize technological processes, and enhance strategic decision-making based on data, contributing significantly to organizational success.\r\n");
        Console.WriteLine("And for that my experience and skills cover several key areas of IT including:\r\n");
        Console.WriteLine("- Software Engineering: Design, development, selection, and evaluation of computer applications and systems.");
        Console.WriteLine("- Databases: Design, implementation, and management of robust and efficient databases..");
        Console.WriteLine("- Distributed Systems: Architecture, implementation, and management of distributed systems for high availability and scalability environments.");
        Console.WriteLine("- Artificial intelligence: Development of intelligent systems and machine learning algorithms for process optimization, and data-driven decision-making.\r\n");
        Console.WriteLine("These skills allow me to design and develop cutting-edge technological solutions, optimize organizational processes, and generate value through the implementation of advanced computer systems.");
    }

    public static void ShowEducation()
    {
        Console.Clear();
        Console.WriteLine("====== Education ======\r\n");
        Console.WriteLine("- Master in Supply Chain Management, Autonomous University of Barcelona, ​​October 2013 - October 2015.");
        Console.WriteLine("- Artificial Intelligence Specialist, International University of La Rioja, October 2024 – present.");
        Console.WriteLine("- Postgraduate in Integrated Logistics, Grancolombiano Polytechnic, May 2013 - July 2013.");
        Console.WriteLine("- Informatics and Computer Engineering, International University of La Rioja, January 2024 – present.");
        Console.WriteLine("- Industrial Engineering, Grancolombiano Polytechnic, January 2010 - June 2013.");
        Console.WriteLine("- Business Administration, University of Valparaíso-Chile, January 2006 - August 2006.");
        Console.WriteLine("- Business Administrator, La Sabana University, January 2002 - December 2007.");
        Console.WriteLine("- Among others.");

    }

    public static void ShowWorkExperience()
    {
        Console.Clear();
        Console.WriteLine("====== Work Experience ======\r\n");
        Console.WriteLine("- I3 Institute. Academic Professor. 05/2024 - Present. Bogotá.");
        Console.WriteLine("- Contractor Campus Inc. Academics Professor. 01/2024 – 06/2024. Bogota.");
        Console.WriteLine("- Anthology Inc. Help Desk Customer Service Supervisor. 10/2022 – 10/2023. Bogota.");
        Console.WriteLine("- Developer Freelance Software. 10/2017 – Present. Bogotá.");
        Console.WriteLine("- Transportation Business Entrepreneurship. Director and Legal Representative. 01/2016 - Present. Bogotá.");
        Console.WriteLine("- Ericsson of Colombia SA Market Logistics Responsible Colombia SA And Ecuador CA 01/2008 – 05/2010. Bogota.");
    }

    public static void ShowPersonalityTraits()
    {
        Console.Clear();
        Console.WriteLine("====== Personality Traits ======\r\n");
        Console.WriteLine("- Empathy, perseverance, and creativity are key traits of my personality that help me manage tense situations effectively. I am a resilient individual with a passion for continuous learning, always seeking opportunities to improve and develop new skills.\r\n");
        Console.WriteLine("- I consider myself spontaneous and outgoing, which enables me to easily build bonds of trust with others. I leverage these characteristics to achieve my goals in both my professional and personal life. I am committed to ethics and honesty in all my transactions and decisions, and I have the ability to anticipate problems and act proactively.\r\n");
        Console.WriteLine("- I learn quickly and am proficient with various software tools. I excel in building interpersonal relationships and am eager to apply my experience and knowledge in the workplace. I approach my work with a strong service attitude and maintain a high level of tolerance for others and their opinions. My personality traits, such as empathy, perseverance, and creativity, enable me to effectively manage tense situations.\r\n");
        Console.WriteLine("- I am a resilient person; a lover of constant learning and I am always looking for opportunities to improve and develop other skills.\r\n");
        Console.WriteLine("- I am a spontaneous and outgoing person, who finds it easy to generate bonds of trust. I take advantage of these characteristics to achieve my goals in my work and personal life.\r\n");
        Console.WriteLine("- Commitment to ethics and honesty in all transactions and decisions. Ability to anticipate problems and act before they arise.\r\n");
        Console.WriteLine("- I must say that I learn quickly, and I master software tools. I have a facility for interpersonal relationships.\r\n");
        Console.WriteLine("- Finally, I am willing to apply everything I have learned in my experience and my career in the workplace, with an excellent service attitude and a high degree of tolerance towards other people and their opinions.");
    }

    public static void ShowLanguages()
    {
        Console.Clear();
        Console.WriteLine("====== Languages ======\r\n");
        Console.WriteLine("- Spanish: Native\r\n");
        Console.WriteLine("- English: Advanced (IELTS certified)\r\n");
        Console.WriteLine("- Portuguese: Intermediate\r\n");
    }

    public static void ShowSkills()
    {
        Console.Clear();
        Console.WriteLine("====== Skills ======\r\n");
        Console.WriteLine("* Programming languages:\r\n- Java \r\n- Python \r\n- PHP \r\n- SQL \r\n- C++ \r\n- HTML/CSS \r\n- JavaScript\r\n");
        Console.WriteLine("* Tools and environments:\r\n- Dev-C++ \r\n- NetBeans \r\n- Looker Studio \r\n- Power BI \r\n- TeXstudio \r\n- Anaconda/Spyder \r\n- Sublime \r\n- XAMPP \r\n- Visual Studio/Azure/Linux/C# \r\n- Power Shell\r\n");
        Console.WriteLine("* Web application development and backend:\r\n- PHP \r\n- Python (Flask and Django)\r\n");
        Console.WriteLine("* Artificial Intelligence:\r\n- Genetic Algorithms, \r\n- Machine Learning, \r\n- Expert Systems\r\n");
        Console.WriteLine("* Databases:\r\n- Oracle, \r\n- MySQL, \r\n- SQL Server, IBM Developer Skills Network\r\n");
        Console.WriteLine("* Agile methodologies:\r\n- SCRUM, \r\n- Kanban\r\n");
        Console.WriteLine("* Software quality:\r\n- ISO 9000/9001 Quality Auditor. \r\n- Law 1581 of 2012\r\n");
        Console.WriteLine("* Visualization tools:\r\n- Power BI \r\n- Looker Studio\r\n");
        Console.WriteLine("* Publishing tools:\r\n- Latex \r\n- TeXstudio\r\n");
        Console.WriteLine("* Among others such as:\r\n- Project Management with Microsoft Project 2010 \r\n- Project Tracking and Control with Microsoft Project 2010 \r\n- Microsoft Access Specialist \r\n- Microsoft Office Specialist \r\n- Project Evaluation at Management Level\r\n");

    }

    public static void ShowFeaturedProjects()
    {
        Console.Clear();
        Console.WriteLine("====== Featured Projects ======\r\n");
        Console.WriteLine("* Route Optimization System: \r\n- Development of a system based on greedy search algorithms to minimize distances in distribution networks\r\n");
        Console.WriteLine("* Academic Management Platform: \r\n- Creation of a web system in PHP to manage courses, users, and academic data.\r\n");
        Console.WriteLine("* Artificial Intelligence Model for Demand Prediction: \r\n- Implementation of neural networks to analyze and predict demands in supply chains\r\n");
        Console.WriteLine("* E-Web Application E-commerce: \r\n- E-commerce platform with inventory management, shopping cart and payment gateway\r\n");
    }

    public static void ShowKeyAchievements()
    {
        Console.Clear();
        Console.WriteLine("====== Key Achievements ======\r\n");
        Console.WriteLine("* Transportation Business Entrepreneurship.\r\n");
        Console.WriteLine("* Logistics and purchasing routing software and e-commerce web app E-commerce.\r\n");
        Console.WriteLine("* Article submitted to a journal indexed in Scopus. \r\n- Title: Route Optimization Based on A* Algorithms and Machine Learning for Distribution Networks \r\n- Magazine: Emerald \r\n- ISSN: 1012-8255\r\n");
        Console.WriteLine("* Improving application performance, team mentoring, and analytics integrations.\r\n");
    }

    public static void ShowReferences()
    {
        Console.Clear();
        Console.WriteLine("====== References ======\r\n");
        Console.WriteLine("Civil engineer. Daniel Ojeda. \r\n- Campus Contractor. \r\n- Mobile phone +57 3102420931\r\n");
        Console.WriteLine("Mechanical Engineer. Enrique Cifuentes. \r\n- Special Transport Caldas SAS. \r\n- Mobile phone +57 3007655010\r\n");
        Console.WriteLine("Business Administrator. Mabel Morales. \r\n- Special Transport Caldas SAS. \r\n- Mobile phone +57 3213483280\r\n");
    }

    public static void ShowValueProposition()
    {
        Console.Clear();
        Console.WriteLine("====== Value Proposition ======\r\n");
        Console.WriteLine("I am a multidisciplinary professional with a solid academic background and experience that converges in the areas of Informatics and Computer Engineering, Business Management, and Emerging Technologies. \r\nMy career also combines a foundation in Industrial Engineering and Business Administration and a Master's in Supply Chain, complemented by a specialization in Artificial Intelligence.\r\n");
        Console.WriteLine("This comprehensive approach has allowed me to lead digital transformation projects, design innovative solutions, and optimize processes in various sectors.\r\n");
        Console.WriteLine("Key Areas of Expertise:\r\n\r\n- Databases: Design, develop, and manage relational and non-relational systems, ensuring scalability, integrity, and information security.\r\n- Distributed Systems: Implementation of scalable and high availability architectures, optimizing the operational efficiency of business applications.\r\n- Artificial intelligence: Creation of machine learning algorithms, data mining, and intelligent systems to automate processes, improve decision making and solve complex problems\r\n");
        Console.WriteLine("Achievements and Outstanding Experience:\r\n\r\n* Leadership in strategic projects in the transport sector, integrating technologies such as Java, Python, PowerShell, SQL, Visual Studio/Azure/Linux/C#, and PHP, together with analysis tools such as Power BI and Looker Studio to:\r\n- Generate actionable insights that optimize logistics planning and execution.\r\n- Implement route prediction and optimization models, improving operational efficiency and customer experience.\r\n* Development of technological solutions based on distributed systems, increasing the reliability and performance of critical operations.\r\n* Experience in technical and professional communication using tools such as LaTeX and TeXstudio to develop high-level documentation and presentations.\r\n");
        Console.WriteLine("Professional Differentiators:\r\n\r\n- International Certifications: ISO 9000 and 9001 Quality Auditor based on Law 581 of 2012, which reinforce my ability to implement and manage quality standards in technological projects.\r\n- Multilingual proficiency: Spanish, English, and Portuguese (IELTS Certification), facilitating collaboration in global and multicultural environments.\r\n");
        Console.WriteLine("Professional Vision:\r\n\r\nMy goal is to lead digital transformation by integrating advanced technologies such as computer systems, artificial intelligence, and data analysis, contributing to the innovation, efficiency, and competitiveness of organizations.\r\n");
        Console.WriteLine("Why Hire Me:\r\n\r\nJoining your team will not only bring a technical and strategic profile capable of designing innovative solutions but also be an ally in generating long-term value for the organization. My experience leading complex projects and my focus on process optimization through technology will guarantee tangible results in terms of efficiency, productivity, and competitiveness.\r\n");
        Console.WriteLine("Finally, I must say that I am committed to turning technological challenges into growth opportunities and aligning business goals with the most advanced and adaptable solutions on the market. Together, we can build a more innovative and successful future for your company.\r\n");
    }
}
