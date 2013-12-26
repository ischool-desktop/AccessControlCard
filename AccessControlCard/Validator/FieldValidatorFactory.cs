using Campus.DocumentValidator;

namespace AccessControlCard
{
    /// <summary>
    /// 用來產生排課系統所需的自訂驗證規則
    /// </summary>
    public class FieldValidatorFactory : IFieldValidatorFactory
    {
        #region IFieldValidatorFactory 成員

        /// <summary>
        /// 根據typeName建立對應的FieldValidator
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="validatorDescription"></param>
        /// <returns></returns>
        public IFieldValidator CreateFieldValidator(string typeName, System.Xml.XmlElement validatorDescription)
        {
            switch (typeName.ToUpper())
            {
                case "STUDENTNUMBEREXISTENCE":
                    return new StudentNumberExistenceValidator(); //學號是否存在系統
                case "STUDENTNUMBERREPEAT":
                    return new StudentNumberRepeatValidator(); //學號是否重覆
                case "STUDENTNUMBERSTATUS":
                    return new StudentNumberStatusValidator(); //學生是一般或延修生
                case "STUDENTIDEXISTENCE":
                    return new StudentIDExistenceValidator(); //學生系統編號是否存在系統
                case "STUDENTIDSTATUS":
                    return new StudentIDStatusValidator(); //學生系統編號必須是一般生
                default:
                    return null;
            }
        }

        #endregion
    }
}