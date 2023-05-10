import { AppComponent } from "./app.component";
import { LoginComponent } from "./authentication/login/login.component";
import { ConfigTextElementComponent } from "./components/AD/config-text-element/config-text-element.component";
import { LanguageTranslateComponent } from "./components/AD/language-translate/language-translate.component";
import { MessageComponent } from "./components/AD/message/message.component";
import { RoleDetailComponent } from "./components/AD/role/role-detail/role-detail.component";
import { RoleComponent } from "./components/AD/role/role.component";
import { UserGroupDetailComponent } from "./components/AD/user-group/user-group-detail/user-group-detail.component";
import { UserGroupComponent } from "./components/AD/user-group/user-group/user-group.component";
import { UserOnlineComponent } from "./components/AD/user-online/user-online.component";
import { UserDetailComponent } from "./components/AD/user/user-detail/user-detail.component";
import { UserComponent } from "./components/AD/user/user/user.component";
import { ContractTypeComponent } from "./components/CM/contract-type/contract-type.component";
import { TemplateContractComponent } from "./components/CM/template-contract/template-contract.component";
import { HomePageComponent } from "./components/home-page/home-page.component";


export const components = [
    AppComponent,
    RoleComponent,
    UserComponent,
    UserDetailComponent,
    MessageComponent,
    ContractTypeComponent,
    LanguageTranslateComponent,
    LoginComponent,
    HomePageComponent,
    UserGroupComponent,
    UserGroupDetailComponent,
    RoleDetailComponent,
    TemplateContractComponent,
    UserOnlineComponent,
    ConfigTextElementComponent
  ];