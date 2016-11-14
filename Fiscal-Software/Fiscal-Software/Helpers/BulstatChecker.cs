﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Helpers
{
    public static class BulstatChecker
    {
        private static int[] FIRST_SUM_9DIGIT_WEIGHTS = { 1, 2, 3, 4, 5, 6, 7, 8 };
        private static int[] SECOND_SUM_9DIGIT_WEIGHTS = { 3, 4, 5, 6, 7, 8, 9, 10 };
        private static int[] FIRST_SUM_13DIGIT_WEIGHTS = { 2, 7, 3, 5 };
        private static int[] SECOND_SUM_13DIGIT_WEIGHTS = { 4, 9, 5, 7 };

        public static bool calculateChecksumForNineDigitsEIK(string eik)
        {
            int[] digits = checkInput(eik, 9);
            int ninthDigit = calculateNinthDigitInEIK(digits);
            return ninthDigit == digits[8];
        }

        public static bool calculateChecksumForThirteenDigitsEIK(string eik)
        {
            int[] digits = checkInput(eik, 13);
            int thirteenDigit = calculateThirteenthDigitInEIK(digits);
            return thirteenDigit == digits[12];
        }

        private static int calculateNinthDigitInEIK(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                sum = sum + (digits[i] * FIRST_SUM_9DIGIT_WEIGHTS[i]);
            }
            int remainder = sum % 11;
            if (remainder != 10)
            {
                return remainder;
            }
            // remainder= 10
            int secondSum = 0;
            for (int i = 0; i < 8; i++)
            {
                secondSum = secondSum + (digits[i] * SECOND_SUM_9DIGIT_WEIGHTS[i]);
            }
            int secondRem = secondSum % 11;
            if (secondRem != 10)
            {
                return secondRem;
            }
            // secondRemainder= 10
            return 0;
        }

        private static int calculateThirteenthDigitInEIK(int[] digits)
        {
            int ninthDigit = calculateNinthDigitInEIK(digits);
            if (ninthDigit != digits[8])
            {
                throw new Exception("Incorrect 9th digit in EIK-13");
            }
            // 9thDigit is a correct checkSum. Continue with 13thDigit
            int sum = 0;
            for (int i = 8, j = 0; j < 4; i++, j++)
            {
                sum = sum + (digits[i] * FIRST_SUM_13DIGIT_WEIGHTS[j]);
            }
            int remainder = sum % 11;
            if (remainder != 10)
            {
                return remainder;
            }
            // remainder= 10
            int secondSum = 0;
            for (int i = 8, j = 0; j < 4; i++, j++)
            {
                secondSum = secondSum + (digits[i] * SECOND_SUM_13DIGIT_WEIGHTS[j]);
            }
            int secondRem = secondSum % 11;
            if (secondRem != 10)
            {
                return secondRem;
            }
            // secondRemainder= 10
            return 0;
        }

        private static int[] checkInput(string eik, int eikLength)
        {
            if (eik != null && eik.Length != eikLength)
            {
                throw new Exception("Invalid input");
            }
            // eik.length= eikLength
            char[] charDigits = eik.ToCharArray();
            int[] digits = new int[charDigits.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                if (char.IsDigit(charDigits[i]))
                {
                    //digits[i] = int.Parse(charDigits[i], 10);
                    digits[i] = int.Parse(charDigits[i].ToString());
                }
                else
                {

                }
            }
            return digits;
        }
    }
}
