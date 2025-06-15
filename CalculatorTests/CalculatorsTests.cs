using zd4_voroshilov;
namespace CalculatorTests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        [TestMethod]
        //Проверка правильности ежемесячного платежа при нормальных значениях
        public void CheckCalculateMonthPayment_Standart_Returned664point29()
        {
            double result = Calculator.CalculateMonthPayment(20000, 36, 12);//полученный ответ

            double expected = 664.29;//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }

        [TestMethod]
        //Проверка правильности ежемесячного платежа при отсутствии процентной ставки
        public void CheckCalculateMonthPayment_MinProcentsRate_Returned1000()
        {
            double result = Calculator.CalculateMonthPayment(12000, 12, 0);//полученный ответ

            double expected = 1000;//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }

        [TestMethod]
        //Проверка правильности общей суммы при нормальных значениях
        public void CheckCalcAllSumPayment_Standart_Returned10830point96()
        {
            double result = Calculator.CalcAllSumPayment(10000, 12, 15);//полученный ответ

            double expected = 10830.96;//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }

        [TestMethod]
        //Проверка правильности общей суммы при отсутствии процентной ставки
        public void CheckCalcAllSumPayment_MinProcentsRate_Returned12000()
        {
            double result = Calculator.CalcAllSumPayment(12000, 12, 0);//полученный ответ

            double expected = 12000;//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }

        [TestMethod]
        //Проверка правильности переплаты при нормальных значениях
        public void CheckCalcOverPayment_Standart_Returned830point96()
        {
            double result = Calculator.CalcOverPayment(10000, 12, 15);//полученный ответ

            double expected = 830.96;//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }

        [TestMethod]
        //Проверка правильности переплаты при отсутствии процентной ставки
        public void CheckCalcOverPayment_MinProcentsRate_Returned12000()
        {
            double result = Calculator.CalcOverPayment(12000, 12, 0);//полученный ответ

            double expected = 0;//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }

        [TestMethod]
        //Проверка правильности проверки суммы кредита и срока месяцев при нормальных значениях
        public void CheckValidSumAndMonths_Standart_ReturnedNothing()
        {
            string result = Calculator.CheckValidSumAndMonths(10000, 12);//полученный ответ

            string expected = "";//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }

        [TestMethod]
        //Проверка правильности проверки суммы кредита и срока месяцев при неправильной сумме кредита
        public void CheckValidSumAndMonths_IncorrectSum_ReturnedNothing()
        {
            string result = Calculator.CheckValidSumAndMonths(100, 12);//полученный ответ

            string expected = "Сумма кредита должна быть больше 1.000 и меньше 100.000.000";//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }

        [TestMethod]
        //Проверка правильности проверки суммы кредита и срока месяцев при неправильном сроке
        public void CheckValidSumAndMonths_IncorrectMonths_ReturnedNothing()
        {
            string result = Calculator.CheckValidSumAndMonths(10000, 500);//полученный ответ

            string expected = "Срок выплаты должен быть в диапазоне от 1 до 360 месяцев";//ожидаемый ответ

            Assert.AreEqual(expected, result);//проверка
        }


    }
}
