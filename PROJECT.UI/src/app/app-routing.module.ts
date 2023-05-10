import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './authentication/login/login.component';
import { LanguageTranslateComponent } from './components/AD/language-translate/language-translate.component';
import { MessageComponent } from './components/AD/message/message.component';
import { RoleDetailComponent } from './components/AD/role/role-detail/role-detail.component';
import { RoleComponent } from './components/AD/role/role.component';
import { UserGroupDetailComponent } from './components/AD/user-group/user-group-detail/user-group-detail.component';
import { UserGroupComponent } from './components/AD/user-group/user-group/user-group.component';
import { UserDetailComponent } from './components/AD/user/user-detail/user-detail.component';
import { UserComponent } from './components/AD/user/user/user.component';
import { ContractTypeComponent } from './components/CM/contract-type/contract-type.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { TemplateContractComponent } from './components/CM/template-contract/template-contract.component';
import { HistoryLoginComponent } from './components/AD/history-login/history-login.component';
import { UserOnlineComponent } from './components/AD/user-online/user-online.component';
import { ConfigTextElementComponent } from './components/AD/config-text-element/config-text-element.component';

const routes: Routes = [
  { path: '', redirectTo: 'Upload', pathMatch: 'full' },
  { path: 'TemplateContract', component: TemplateContractComponent },
  { path: 'Home', component: HomePageComponent },
  { path: 'Login', component: LoginComponent},
  
  { path: 'Message', component: MessageComponent },
  { path: 'ContractType', component: ContractTypeComponent },
  { path: 'Role', component: RoleComponent },
  { path: 'Role/Detail/:code', component: RoleDetailComponent },
  { path: 'User', component: UserComponent, data: { reuse: true } },
  { path: 'LanguageTranslate', component: LanguageTranslateComponent },
  { path: 'ConfigTextElement', component: ConfigTextElementComponent},

  { path: 'User/UserDetail/:username', component: UserDetailComponent },
  { path: 'UserGroup', component: UserGroupComponent},
  { path: 'UserGroup/Detail/:code', component: UserGroupDetailComponent },
  { path: 'HistoryLogin', component: HistoryLoginComponent},
  { path: 'UserOnline', component: UserOnlineComponent},
  { path: 'SystemManage', loadChildren: () => import('./@module/system-manage/system-manage.module').then(m => m.SystemManageModule) },
  { path: 'MasterData', loadChildren: () => import('./@module/master-data/master-data.module').then(m => m.MasterDataModule) },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
