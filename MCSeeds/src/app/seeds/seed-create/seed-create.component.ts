import { Component, OnInit } from '@angular/core';
import { SeedsService } from 'src/app/shared/seeds.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-seed-create',
  templateUrl: './seed-create.component.html',
  styleUrls: ['./seed-create.component.css']
})
export class SeedCreateComponent implements OnInit {

  constructor(private service:SeedsService) { }

  ngOnInit() {
    this.resetForm();
  }

resetForm(form?: NgForm){
  if (form != null)
    form.resetForm();
  this.service.formData = {
    SeedID: 0,
    Title: '',
    SeedValue: '',
    Description: '',
    ImageID: 0,
    versionID: 0
  }
}

onSubmit(form: NgForm){
  form.value
}

}
