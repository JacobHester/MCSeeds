import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http'

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { SeedsComponent } from './seeds/seeds.component';
import { SeedListComponent } from './seeds/seed-list/seed-list.component';
import { SeedDetailComponent } from './seeds/seed-detail/seed-detail.component';
import { SeedCreateComponent } from './seeds/seed-create/seed-create.component';
import { SeedsService } from './shared/seeds.service';
import { from } from 'rxjs';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SeedsComponent,
    SeedListComponent,
    SeedDetailComponent,
    SeedCreateComponent
  ],
  imports: [
    BrowserModule,
    AngularFontAwesomeModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [SeedsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
