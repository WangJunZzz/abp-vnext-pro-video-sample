namespace MyLion.Erp.Settings
{
    public class ErpSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ErpSettings.MySetting1));
            OverrideDefalutSettings(context);
        }

        /// <summary>
        /// 重写默认setting添加自定义属性
        /// </summary>
        private static void OverrideDefalutSettings(ISettingDefinitionContext context)
        {
            
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ErpResource>(name);
        }
    }
}