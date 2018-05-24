import { Component, OnInit } from '@angular/core';
import { DictionaryService } from './dictionary.service';
import { Dictionary } from './dictionary.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title: string;
  dictionaries: Dictionary[];

  ngOnInit(): void {
    this.onGet();
  }

  constructor(private dictionaryService: DictionaryService) { }

  onGet() {
    this.dictionaryService.getDictionaries()
      .subscribe(response =>
        this.dictionaries = response
      );
  }

  display() {
    console.log(this.dictionaries[0]);
    this.title = this.dictionaries[0].name;
  }
}
