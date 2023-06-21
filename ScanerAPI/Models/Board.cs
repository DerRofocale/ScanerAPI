namespace ScanerAPI.Models
{
    public class Board
    {
        /// <summary>
        /// Обзол (кол-во) - 0
        /// </summary>
        public required int wane { get; set; }
        /// <summary>
        /// Плесень (кол-во) - 0
        /// </summary>
        public required int mold { get; set; }
        /// <summary>
        /// Сквозные отверстия (кол-во) - 0
        /// </summary>
        public required int holes { get; set; }
        /// <summary>
        /// Длина (мм) - 0
        /// </summary>
        public required int length { get; set; }
        /// <summary>
        /// Ширина (мм) - 0.00
        /// </summary>
        public required double width { get; set; }
    }
}
