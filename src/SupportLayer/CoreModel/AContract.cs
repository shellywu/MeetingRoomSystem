namespace SupportLayer.CoreModel
{
    public abstract class AContract
    {
        public  int Id { get; set; }
        public abstract AUser User { get; set; }
        /// <summary>
        /// 联系方式：qq，微信，等等
        /// </summary>
        public  string ContractMethod { get; set; }
        public  string ContractValue { get; set; }
        /// <summary>
        /// 对谁可见
        /// </summary>
        public  int VisibleLevel { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        public  bool Status { get; set; }
    }
}
