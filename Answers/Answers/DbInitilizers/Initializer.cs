using System.Collections.Generic;
using Answers.Models;

namespace Answers.DbInitilizers
{
    internal class Initializer
    {
        public List<QuestionModel> GetInitizlizedList()
        {
            var list = new List<QuestionModel>();
            list.Add(new QuestionModel("1. His cousin doesn't go to _____ school on _____ Sunday.", "А) — , —"));
            list.Add(new QuestionModel("2. He didn't even know ______ Browns had a daughter.", "А) —"));
            list.Add(new QuestionModel("3. ______ Dnieper is	_______ main river in ______ Ukraine.", "А) — , the, —"));
            list.Add(new QuestionModel("4. _______ Parkers won lottery last week.", "А) —"));
            list.Add(new QuestionModel("5. He bought _____ book at the supermarket yesterday.", "D) the"));
            list.Add(new QuestionModel("6. The bee was buzzing among ____ flowers in the vase.", "D) the"));
            list.Add(new QuestionModel("7. He turned and saw _____ crying boy.", "D) the"));
            list.Add(new QuestionModel("8. What _____ marvelous English souvenirs you’ve bought!", "А) —"));

            list.Add(new QuestionModel("9. We always have ____ dinner at twelve o'clock", "А) —"));
            list.Add(new QuestionModel("10. My mother was _____ only person whom I told waht had happened", "А) —"));
            list.Add(new QuestionModel("11. ___ man under such circunstances is always very helpless", "C) A"));
            list.Add(new QuestionModel("12. My ____ child enjoys playing with his father very much", "B) brother's"));
            list.Add(new QuestionModel("13. ____ the end of each class our teacher gives us our homework", "B) At"));
            list.Add(new QuestionModel("14. The news of such a kind ____ very important", "A) is"));
            list.Add(new QuestionModel("15. Let's translate this article ____ Ukrainian", "C) into"));
            list.Add(new QuestionModel("16. Classes are over ____ 3 o'clock", "A) in"));
            list.Add(new QuestionModel("17. The inspector could see just a table ____ a sheet of paper ____ it", "A) with, on"));
            list.Add(new QuestionModel("18. The man took a journal ____ the case and gave it to me", "C) out of"));
            list.Add(new QuestionModel("19. He works ___ morning ___ night", "A) from, till"));
            list.Add(new QuestionModel("20. Are you going?", "A) somewhere"));
            list.Add(new QuestionModel("21. She didn't tell ____ about her plans", "C) anybody"));
            list.Add(new QuestionModel("22. Some cars can go faster than ____", "B) others"));
            list.Add(new QuestionModel("23. We haven't got ____ milk. Could you buy ____ on your way home?", "С) any, some"));
            list.Add(new QuestionModel("24. Sue took as ____ books as she could carry herself", "D) many"));
            list.Add(new QuestionModel("25. She promised _____ to behave better next time", "C) them"));
            list.Add(new QuestionModel("26. Give me ____ pen, I've lost", "A) your, my"));
            list.Add(new QuestionModel("27. I haven't got ____ time, but I'll try to help you", "A) much"));
            list.Add(new QuestionModel("28. ____ can translate the following sentence", "C) Anybody"));
            list.Add(new QuestionModel("29. He told me ____ about his problems", "A) some"));
            list.Add(new QuestionModel("30. You can take ____ car you like", "A) any"));
            list.Add(new QuestionModel("31. Michael has got ____ English books at home", "C) a lot of"));
            list.Add(new QuestionModel("32. This suitcase is _____ than that one", "A) heavier"));
            list.Add(new QuestionModel("33. When Ted found a new job, he became ____ on his parents", "C) less dependent"));
            return list;
        }

    }
}
