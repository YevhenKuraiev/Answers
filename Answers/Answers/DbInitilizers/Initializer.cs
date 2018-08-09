using System.Collections.Generic;
using System.Linq;
using Answers.Models;

namespace Answers.DbInitilizers
{
    internal class Initializer
    {
        public List<QuestionModel> GetInitizlizedList()
        {
            var list = new List<QuestionModel>();

            #region Yevhen

            list.Add(new QuestionModel("1. His cousin doesn't go to _____ school on _____ Sunday.", "А) — , —"));
            list.Add(new QuestionModel("2. He didn't even know ______ Browns had a daughter.", "D) the"));
            list.Add(new QuestionModel("3. ______ Dnieper is	_______ main river in ______ Ukraine.", "B) the , a, the"));
            list.Add(new QuestionModel("4. _______ Parkers won lottery last week.", "D) the"));
            list.Add(new QuestionModel("5. He bought _____ book at the supermarket yesterday.", "C) a"));
            list.Add(new QuestionModel("6. The bee was buzzing among ____ flowers in the vase.", "D) the"));
            list.Add(new QuestionModel("7. He turned and saw _____ crying boy.", "B) a"));
            list.Add(new QuestionModel("8. What _____ marvelous English souvenirs you’ve bought!", "А) —"));
            list.Add(new QuestionModel("9. We always have ____ dinner at twelve o'clock", "А) —"));
            list.Add(new QuestionModel("10. My mother was _____ only person whom I told waht had happened", "D) the"));
            list.Add(new QuestionModel("11. ___ man under such circunstances is always very helpless", "C) A"));
            list.Add(new QuestionModel("12. My ____ child enjoys playing with his father very much", "B) brother's"));
            list.Add(new QuestionModel("13. ____ the end of each class our teacher gives us our homework", "B) At"));
            list.Add(new QuestionModel("14. The news of such a kind ____ very important", "A) is"));
            list.Add(new QuestionModel("15. Let's translate this article ____ Ukrainian", "C) into"));
            list.Add(new QuestionModel("16. Classes are over ____ 3 o'clock", "B) at"));
            list.Add(new QuestionModel("17. The inspector could see just a table ____ a sheet of paper ____ it", "A) with, on"));
            list.Add(new QuestionModel("18. The man took a journal ____ the case and gave it to me", "C) out of"));
            list.Add(new QuestionModel("19. He works ___ morning ___ night", "A) from, till"));
            list.Add(new QuestionModel("20. Are you going?", "A) somewhere"));
            list.Add(new QuestionModel("21. She didn't tell ____ about her plans", "C) anybody"));
            list.Add(new QuestionModel("22. Some cars can go faster than ____", "B) others"));
            list.Add(new QuestionModel("23. We haven't got ____ milk. Could you buy ____ on your way home?", "С) any, some"));
            list.Add(new QuestionModel("24. Sue took as ____ books as she could carry herself", "D) many"));
            list.Add(new QuestionModel("25. She promised _____ to behave better next time", "C) them"));
            list.Add(new QuestionModel("26. Give me ____ pen, I've lost", "C) your, mine"));
            list.Add(new QuestionModel("27. I haven't got ____ time, but I'll try to help you", "A) much"));
            list.Add(new QuestionModel("28. ____ can translate the following sentence", "B) None of us"));
            list.Add(new QuestionModel("29. He told me ____ about his problems", "B) anything"));
            list.Add(new QuestionModel("30. You can take ____ car you like", "A) any"));
            list.Add(new QuestionModel("31. Michael has got ____ English books at home", "C) a lot of"));
            list.Add(new QuestionModel("32. This suitcase is _____ than that one", "A) heavier"));
            list.Add(new QuestionModel("33. When Ted found a new job, he became ____ on his parents", "C) less dependent"));

            list.Add(new QuestionModel("68. What happened to the old mail carrier? He ____ to a new neighborhood to work last week", "C) was sent"));
            list.Add(new QuestionModel("69. Gold ____ in California in the 19 century", "А) was discovered"));
            list.Add(new QuestionModel("70. What beautiful dress you're wearing! Thanks! It ____ especially for me by a French tailor", "B) has been made"));
            list.Add(new QuestionModel("71. Who does the washing-up in your house? - The dishes __ by my brother and then they __ by my sister", "A) are washed, are dried"));
            list.Add(new QuestionModel("72. Why can't I use your car? Because it ____ at the moment", "D) is being serviced"));
            list.Add(new QuestionModel("73. When I realized I was wrong. I apologized ____ my mistake", "A) for"));
            list.Add(new QuestionModel("74. Who is going to look ____ your children while you are away", "D) after"));
            list.Add(new QuestionModel("75. What are you accused ____?", "A) of"));
            list.Add(new QuestionModel("76. Here is the man who insists ____ your coming", "D) on"));
            list.Add(new QuestionModel("77. Nobody could account ____ his objection to our plan", "C) for"));
            list.Add(new QuestionModel("78. Her son succeeded ___ winning the prize in the competition", "C) in"));
            list.Add(new QuestionModel("79. You ____ stop when the traffic light is red", "D) must"));
            list.Add(new QuestionModel("80. Sorry, I ___ go now. My bus leaves in a few minutes", "B) have to"));
            list.Add(new QuestionModel("81. He ____ get a taxi because I gave him a lift", "B) didn't need to"));
            list.Add(new QuestionModel("82. This is the new catalogue ___ I have it for a moment, please?", "B) Can"));
            list.Add(new QuestionModel("83. He ____ have left the keys on the table", "D) might"));
            list.Add(new QuestionModel("84. ____ please give me a call", "A) Should he come"));
            list.Add(new QuestionModel("85. I ____ stay at home as I felt very bad", "D) had to"));
            list.Add(new QuestionModel("86. He was trying to repair his car. He seemed to ____ repair it as it is working", "B) be able to"));
            list.Add(new QuestionModel("87. You ____ go to the college immediatly. Do you understand me?", "D) must"));
            list.Add(new QuestionModel("88. If I ____ some spare time, I would have devoted it to reading", "C) had had"));
            list.Add(new QuestionModel("89. If I see Tim. I ____ him his book.", "B) will give"));
            list.Add(new QuestionModel("90. You ____ better results if you apply this method", "A) will achieve"));
            list.Add(new QuestionModel("91. They denied ____ the money", "C) stealing"));
            list.Add(new QuestionModel("92. I don't enjoy ____ very much.", "C) driving"));
            list.Add(new QuestionModel("93. I don't want ___ out tonight I'm too tired", "B) to go"));
            list.Add(new QuestionModel("94. Why do you keep ___ me questions? Can't you leave me alone?", "D) asking"));
            list.Add(new QuestionModel("95. The boy gave up ___ to escape from the lessons", "A) trying"));
            list.Add(new QuestionModel("96. Has it stopped ___ yet?", "A) raining"));
            list.Add(new QuestionModel("97. Can you remind me ___ some coffee when we go out?", "B) to buy"));
            list.Add(new QuestionModel("98. Did you advise him ___ to the police? - No, I didn't like ___ any advice on such a dificult maner.", "С) to go, to give"));
            list.Add(new QuestionModel("99. It's no use ___ to him", "A) writing"));
            list.Add(new QuestionModel("100. I wish it ___ raining. I have to go to the shop", "C) has stopped"));

            //variant 2
            list.Add(new QuestionModel("1. He found ___ purse in the street yesterday", "B) a"));
            list.Add(new QuestionModel("2. I saw him ___ day before yesterday", "B) a"));
            list.Add(new QuestionModel("3. Your father is such ____ interesting person", "C) an"));
            list.Add(new QuestionModel("4. She had ___ most intelligent brown eyes Tim had ever seen", "D) the"));
            list.Add(new QuestionModel("5. She turned and saw ____ laughing girl", "B) a"));
            list.Add(new QuestionModel("6. ___ British are a nation of newspaper readers", "D) The"));
            list.Add(new QuestionModel("7. What ____ beautiful picture you've bought", "B) a"));
            list.Add(new QuestionModel("8. ____ Times is the most popular newspaper among British readers", "A) -"));
            list.Add(new QuestionModel("9. I asked my father for ____ advice about finding ____ job", "D) -, a"));
            list.Add(new QuestionModel("10. My friends have never travelled across ____ Atlantic", "B) the"));
            list.Add(new QuestionModel("11. ___ Manhattan is in ____ New York", "C) -, -"));
            list.Add(new QuestionModel("12. My ___ room is very comfortable", "C) father and mother's"));
            list.Add(new QuestionModel("13. Jane usually goes to college ____ bus", "А) by"));
            list.Add(new QuestionModel("14. Don't worry! Everything is ___ control", "D) under"));
            list.Add(new QuestionModel("15. That is what he wanted to begin ____", "B) with"));
            list.Add(new QuestionModel("16. I've been here ____ two weeks", "C) for"));
            list.Add(new QuestionModel("17. Ann came ____ the room and sat down ___ the table", "A) into, at"));
            list.Add(new QuestionModel("18. My friend rang me up and asked me out ___ a walk", "C) for"));
            list.Add(new QuestionModel("19. I'am hungry. I want ___ to eat.", "B) something"));
            list.Add(new QuestionModel("20. We had to walk home because there was ___ bus", "D) no"));
            list.Add(new QuestionModel("21. How long have you and Bill known each ___?", "A) other"));
            list.Add(new QuestionModel("22. We've got ___ time before the train leaves. Let's go and have a drink", "D) a little"));
            list.Add(new QuestionModel("23. She is lucky. She doen't have ____ problems", "A) many"));
            list.Add(new QuestionModel("24. The children hurt ____ when they fell over", "C) themselves"));
            list.Add(new QuestionModel("25. He wants more milk. Give him ___", "C) some"));
            list.Add(new QuestionModel("26. I saw ____ at the window", "A) somebody"));
            list.Add(new QuestionModel("27. We have done it ____", "C) ourselves"));
            list.Add(new QuestionModel("28. Could you give me a pen. I left ___ at home.", "A) mine"));
            list.Add(new QuestionModel("29. ____ of the students knows English?", "A) Who"));
            list.Add(new QuestionModel("30. There was ____ to do but wait", "D) nothing"));
            list.Add(new QuestionModel("31. We'll have to leave a bit ____ than we planned", "B) earlier"));
            list.Add(new QuestionModel("32. What is ____ river in the world?", "D) the longest"));
            list.Add(new QuestionModel("33. February was ____ month of the year", "B) the coldest"));

            #endregion

            #region Mo

            list.Add(new QuestionModel("1. ____ Dead Sea is very salty.", "A) The"));
            list.Add(new QuestionModel("2. ____ Nile is ____ longest river in ____ Africa", "B) The, the, -"));
            list.Add(new QuestionModel("3. I promise to tell ____ truth ____ whole truth and nothing but ____ truth", "C) the, the, -"));
            list.Add(new QuestionModel("4. Information ____ available at the front desk.", "A) is"));
            list.Add(new QuestionModel("5. ____ Chicago is on ____ Lake Michigan.", "C) -, -"));
            list.Add(new QuestionModel("6. My uncle plays ____ violin in an orchestra", "D) the"));
            list.Add(new QuestionModel("7. I like citites, I wouldn't like to live in ____ country", "D) the"));
            list.Add(new QuestionModel("8. I said I'd been driving at 95 miles ____ hour", "B) an"));
            list.Add(new QuestionModel("9. It's ____ walk from here to the university", "C) an hour's"));
            list.Add(new QuestionModel("10. I bought a few ____ for my husband", "A) handkerchiefs"));
            list.Add(new QuestionModel("11. Sally will stay ____ her mother comes", "B) until"));
            list.Add(new QuestionModel("12. Last year Jane received one letter a week ____ the average", "C) on"));
            list.Add(new QuestionModel("13. Yesterday we got an invitation ____ the party", "B) to"));
            list.Add(new QuestionModel("14. The soldiers marched ____ the Queen", "C) past"));
            list.Add(new QuestionModel("17. I see that he has lost ____ pencil; perhaps you can lend him ____ ?", "B) his, yours"));
            list.Add(new QuestionModel("18. Bill had a great holiday. He enjoyed ____", "D) himself"));
            list.Add(new QuestionModel("19. We had an unexpected guest. ____ Susan", "A) It was"));
            list.Add(new QuestionModel("20. It doesn't matter if someone is male or female, ____ should be accepted as a member", "D) they"));
            list.Add(new QuestionModel("21. I've heard of Iris Murdoch, but I haven't read ____ of her books.", "B) any"));
            list.Add(new QuestionModel("22. There are ____ things I'd like to say", "D) a lot"));
            list.Add(new QuestionModel("23. Ann didn't say ____ about that in her last letter", "C) anything"));
            list.Add(new QuestionModel("24. I have never been ____ more beautiful than Scotland", "B) anywhere"));
            list.Add(new QuestionModel("25. If ____ calls while I'm out, ask him to wait", "B) anybody"));
            list.Add(new QuestionModel("26. It's ____ essential we don't tell anyone", "A) absolutely"));
            list.Add(new QuestionModel("27. You should give the iron time to heat up ____ you iron your clothes", "A) before"));
            list.Add(new QuestionModel("28. They saw snow is ____ That's right. It'll ____ snow tomorrow morning", "D) likely, probably"));
            list.Add(new QuestionModel("29. The rumour was ____ false", "C) completely"));
            list.Add(new QuestionModel("30. ____ we get up, ____ we'll leave.", "C) The earlier, the sooner"));
            list.Add(new QuestionModel("31. Go by train! It's ____ .", "D) much cheaper"));
            list.Add(new QuestionModel("32. When James found a new job, he became ____ on his parents.", "B) less dependent"));
            list.Add(new QuestionModel("33. I don't know why but today they sing ____ usual", "A) worse than"));
            list.Add(new QuestionModel("34. It was quite ____ that he passed the exam", "A) surprising"));
            list.Add(new QuestionModel("35. The book was so ____ that I couldn't put it down.", "D) good"));
            list.Add(new QuestionModel("36. English is ____ Spanish.", "A) as difficult as"));
            list.Add(new QuestionModel("37. We always listen to ____ ", "A) the lastest"));
            list.Add(new QuestionModel("38. This bag is slightly ____ .", "A) heavy"));
            list.Add(new QuestionModel("39. ____ the weather is, ____ I feel", "C) The warmer, the better"));
            list.Add(new QuestionModel("40. This man is ____ than me", "B) taller"));
            list.Add(new QuestionModel("41. Jason ____ Amanda since he was five years old.", "B) has known"));
            list.Add(new QuestionModel("42. When I ____ over the phone, my friend ____.", "A) was speaking, was reading"));
            list.Add(new QuestionModel("43. When I got up that morning, the sun ____ brightly and the birds ____", "B) was shining, were singing"));
            list.Add(new QuestionModel("44. I ____ hard all day. I'm exhausted.", "A) have been working"));
            list.Add(new QuestionModel("45. Rebecca suddenly understood that she ____ him all her life.", "B) had loved"));
            list.Add(new QuestionModel("46. The windows ____ once a month.", "C) are cleaned"));
            list.Add(new QuestionModel("47. Look at the sunshine! It ____ a beautiful day.", "B) is going to be"));
            list.Add(new QuestionModel("48. Fred ____ every day for the last six months.", "B) has been exercising"));
            list.Add(new QuestionModel("49. They ____ to Austria last winter", "B) went"));
            list.Add(new QuestionModel("50. A new magazine ____ next week", "A) will be published"));
            list.Add(new QuestionModel("51. This time next week I ____ a dictation.", "D) will be writing"));
            list.Add(new QuestionModel("52. By yesterday the teacher ____ all the students.", "D) had examined"));
            list.Add(new QuestionModel("53. He ____ just ____ two big sandwiches", "D) has, eaten"));
            list.Add(new QuestionModel("54. 'Have you ever appeared on TV?' Actually, I ____ to take part in a show last month.", "C) was asked"));
            list.Add(new QuestionModel("55. 'When will I have my car serviced?' It ____ to your house the day after tomorrow", "B) will be delivered"));
            list.Add(new QuestionModel("56. When we came into the hall they ____ this problem.", "D) were discussing"));
            list.Add(new QuestionModel("57. They ____ the University three years ago", "B) entered"));
            list.Add(new QuestionModel("58. 'Who looks after your baby when you're at work?' He ____ after by my mother.", "C) is being looked"));
            list.Add(new QuestionModel("59. 'What will happen to the criminals?'They ____ for their crimes", "B) will be punished"));
            list.Add(new QuestionModel("60. 'Did you post the letters?' - 'No, they ____ by the time I came in", "A) had been posted"));
            list.Add(new QuestionModel("61. When they entered the hall the performance ____ .", "C) had already begun"));
            list.Add(new QuestionModel("62. They were happy to hear they ____ a prize.", "A) had won"));
            list.Add(new QuestionModel("63. I'm tired. 'So am I. But these reports must ____ before we leave.", "B) be typed"));
            list.Add(new QuestionModel("64. 'Why can't we go over the bridge?' 'Because it ____ at the moment.", "A) is being repaired"));
            list.Add(new QuestionModel("65. 'So, when did they tell you about the robbery?' 'I ____ by the police as soon as they found it out", "D) was informed"));
            list.Add(new QuestionModel("66. She would like to know if I ____ to the theatre.", "A) will go"));
            list.Add(new QuestionModel("67. You said that you ____ in time", "C) would come"));
            list.Add(new QuestionModel("68. The boy said that he ____ to the radio at nine p.m. that day", "A) had listened"));
            list.Add(new QuestionModel("69. 'Those pictures are beautiful'They ____ by my father while he was on holiday last summer", "A) were painted "));
            list.Add(new QuestionModel("70. We spent the evening listening ____ the music", "C) to"));
            list.Add(new QuestionModel("71. He's very selfish. He doesn't care ____ other people.", "B) about"));
            list.Add(new QuestionModel("72. I'm not going out yet. I'm waiting ____ the rain to stop.", "B) for"));
            list.Add(new QuestionModel("73. I've lost my keys. Can you help me to look ____ them.", "D) for"));
            list.Add(new QuestionModel("74. You will break ____ if you work too hard.", "B) down"));
            list.Add(new QuestionModel("75. I was taken ____ by his appearance", "B) in"));
            list.Add(new QuestionModel("76. You ____ run in the corridors. It's dangerous.", "D) shouldn't"));
            list.Add(new QuestionModel("77. They have got a huge house. They ____ be rich", "B) must"));
            list.Add(new QuestionModel("78. ____ you open the window?", "D) Could"));
            list.Add(new QuestionModel("79. The phone rang but I didn't hear it. I ____ in the garden", "A) must have been working"));
            list.Add(new QuestionModel("80. You look tired. You ____ go to bed", "B) have to"));
            list.Add(new QuestionModel("81. The situation was bad but it ____ worse.", "A) could have been"));
            list.Add(new QuestionModel("82. Jack was an excellent tennis player. He ____ beat anybody.", "B) could"));
            list.Add(new QuestionModel("83. We ____ see the lake from our bedroom window.", "A) can"));
            list.Add(new QuestionModel("84. Suppose the boss ____ now, what will you say?", "B) comes"));
            list.Add(new QuestionModel("85. If I found a wallet in the street, I ____ it to the police", "B) would take"));
            list.Add(new QuestionModel("86. We wouldn't have any money if we ____ .", "C) didn't work"));
            list.Add(new QuestionModel("87. I ____ the phone if I had known it was him", "D) wouldn't have answered"));
            list.Add(new QuestionModel("88. If he ____ his medical studies, he would have become a doctor.", "B) had finished"));
            list.Add(new QuestionModel("89. I stopped ____ television because the film was boring", "D) watching"));
            list.Add(new QuestionModel("90. It's snowing! I wish it ____ snowing", "A) would stop"));
            list.Add(new QuestionModel("91. The boy feels sick. He wishes he ____ so many cakes before.", "A) hadn't eaten"));
            list.Add(new QuestionModel("92. You had better ____ your umbrella with you today.", "C) take"));
            list.Add(new QuestionModel("93. I would like ____ this film.", "A) to see"));
            list.Add(new QuestionModel("94. I can hear the bell ____ ", "A) ringing"));
            list.Add(new QuestionModel("95. Please, go on ____, I don't mind ____ .", "D) writing, waiting"));
            list.Add(new QuestionModel("96. Most people prefer ____ money to ____ it.", "B) spending, earning"));
            list.Add(new QuestionModel("97. He tried ____ but she didn't want ____ to anybody.", "C) to explain, to listen"));
            list.Add(new QuestionModel("98. I'm looking forward to ____ you.", "B) seeing"));
            list.Add(new QuestionModel("99. Mary complained of not ____ to the party last Friday", "D) having been invited"));
            list.Add(new QuestionModel("100. The student used the method ____ in this article", "C) described"));

            #endregion

            #region Bard

            list.AddRange(new QuestionReaderService("Answers.DbInitilizers.answers.json").GetInputData().ToList());

            #endregion

            return list;
        }

    }
}
