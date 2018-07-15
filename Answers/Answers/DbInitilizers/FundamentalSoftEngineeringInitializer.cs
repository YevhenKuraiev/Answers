using System;
using System.Collections.Generic;
using System.Text;
using Answers.Models;

namespace Answers.DbInitilizers
{
    internal class FundamentalSoftEngineeringInitializer
    {
        public List<TextQuestionModel> GetInitizlizedList()
        {
            return new List<TextQuestionModel>
            {
                new TextQuestionModel
                {
                    QuestionText = "Главными областями программной инженерии согласно SWEBOK являются...",
                    AnswerText = "инженерия требований"
                },
                new TextQuestionModel
                {
                    QuestionText = "Организационными областями программной инженерии согласно SWEBOK являются...",
                    AnswerText = "управление конфигурацией; процесс инженерии ПС"
                },
                new TextQuestionModel
                {
                    QuestionText = "Главными областями программной инженерии согласно SWEBOK не являются...",
                    AnswerText = "управление конфигурацией; процесс инженерии ПС"
                },
                new TextQuestionModel
                {
                    QuestionText = "Валидация требований - это:...",
                    AnswerText =
                        "проверка полноты, непротиворечивости и однозначности спецификации и правильности выполнения функций системы в соответствии с требованиями"
                },
                new TextQuestionModel
                {
                    QuestionText =
                        "Основные систематические методы обеспечения правильности программ включают в себя:...",
                    AnswerText = "верификация компонентов; валидация требований"
                },
                new TextQuestionModel
                {
                    QuestionText = "Для каких задач управления проектом используется диаграмма Ганта?",
                    AnswerText = "планирование проекта и составление графиков работ выполнения проекта"
                },
                new TextQuestionModel
                {
                    QuestionText = "Управление проектом - это:",
                    AnswerText =
                        "руководство работами команды исполнителей проекта для реализации проекта с использованием методов управления, планирования и контроля работ, управление рисками," +
                        " эффективной организацией работы и коммуникационными потоками в команде исполнителей"
                },
                new TextQuestionModel
                {
                    QuestionText = "Планирование - это:",
                    AnswerText =
                        "процесс распределения и назначения ресурсов (материальных и людских) с учетом стоимости и времени выполнения проекта"
                },
                new TextQuestionModel
                {
                    QuestionText = "Основными составляющими любого проекта являются:",
                    AnswerText = "ресурсы; время выполнения проекта; стоимость выполнения проекта"
                },
                new TextQuestionModel
                {
                    QuestionText = "Ответственность за координацию и реализацию основных составляющих проекта несет:",
                    AnswerText = "менеджер проекта"
                }
            };
        }

        
    }
}
