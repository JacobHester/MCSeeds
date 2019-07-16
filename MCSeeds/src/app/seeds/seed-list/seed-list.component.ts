import { Component, OnInit } from '@angular/core';
import { SeedsService } from 'src/app/shared/seeds.service';

@Component({
  selector: 'app-seed-list',
  templateUrl: './seed-list.component.html',
  styleUrls: ['./seed-list.component.css']
})
export class SeedListComponent implements OnInit {

  constructor(private service:SeedsService) { }

  ngOnInit() {
  }

}
