using System;
using System.Collections.Generic;

namespace LibraryDesk.Core
{
    /// <summary>
    /// Представляє видачу книг читачеві.
    /// </summary>
    public class BookIssue
    {
        private readonly List<string[]> _copies = new List<string[]>();

        public string Id { get; private set; }

        public string ReaderName { get; private set; }

        public int Status { get; private set; }

        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Створює нову видачу книг.
        /// </summary>
        public BookIssue(string issueId, string readerName)
        {
            Id = issueId;
            ReaderName = readerName;
            Status = 0;
            CreatedAt = DateTime.Now;
        }

        /// <summary>
        /// Додає примірник до видачі.
        /// </summary>
        public void AddCopy(string copyId, int quantity)
        {
            string[] copyEntry = new string[2];
            copyEntry[0] = copyId;
            copyEntry[1] = quantity.ToString();

            _copies.Add(copyEntry);
        }

        /// <summary>
        /// Обчислює загальну кількість примірників.
        /// </summary>
        public int CalculateTotalCopies()
        {
            int totalCopies = 0;
            int lineCount = 0;

            for (int index = 0; index < _copies.Count; index++)
            {
                int quantity = int.Parse(_copies[index][1]);

                totalCopies = totalCopies + quantity;
                lineCount = lineCount + 1;
            }

            if (totalCopies < 0)
            {
                totalCopies = 0;
            }

            return totalCopies;
        }

        /// <summary>
        /// Змінює статус видачі відповідно до дозволених переходів.
        /// </summary>
        public bool TryChangeStatus(int newStatus)
        {
            if (Status == 0 && newStatus == 1)
            {
                Status = 1;
                return true;
            }

            if (Status == 1 && newStatus == 2)
            {
                Status = 2;
                return true;
            }

            if (Status == 0 && newStatus == 3)
            {
                Status = 3;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Перевіряє коректність даних видачі.
        /// </summary>
        public bool IsValid()
        {
            if (!string.IsNullOrEmpty(Id)
                && ReaderName != null
                && ReaderName.Length > 2
                && _copies.Count > 0
                && _copies.Count < 100
                && Status >= 0
                && Status <= 3)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Формує текстовий звіт про видачу.
        /// </summary>
        public string BuildReport()
        {
            string report = string.Empty;

            for (int index = 0; index < _copies.Count; index++)
            {
                report = report
                    + "Примірник: " + _copies[index][0]
                    + "; кількість: " + _copies[index][1]
                    + "\n";
            }

            report = report
                + "Загальна кількість виданих примірників: "
                + CalculateTotalCopies()
                + "\n";

            return report;
        }

        /// <summary>
        /// Знаходить видачу за її ідентифікатором.
        /// </summary>
        public static BookIssue? FindById(
            List<BookIssue> issues,
            string issueId)
        {
            for (int index = 0; index < issues.Count; index++)
            {
                if (issues[index].Id == issueId)
                {
                    return issues[index];
                }
            }

            return null;
        }
    }
}