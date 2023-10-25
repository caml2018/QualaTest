import { Component, EventEmitter, Input, Output, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.scss']
})
export class TableComponent {
  @Input() title = "";
  @Input() tableData: any[] =[];
  @Input() displayedColumns: any[]=[];
  @Input() columns:any[]=[]
  @Output() updateEvent = new EventEmitter<any>();
  @Output() deleteEvent = new EventEmitter<any>();

  displayedColumnsadd: any[]=[];
  
  dataSource!: MatTableDataSource<any>;

  sort:any;
  paginator:any;

  @ViewChild(MatSort) set matSort(ms: MatSort) {
    this.sort = ms;
    this.setDataSourceAttributes();
  }

@ ViewChild(MatPaginator) set matPaginator(mp: MatPaginator) {
    this.paginator = mp;
    this.setDataSourceAttributes();
  }
  // @ViewChild('scheduledOrdersPaginator') set paginator(pager:MatPaginator) {
  //   if (pager) this.dataSource.paginator = pager;
  // }
  // @ViewChild(MatSort) set sort(sorter:MatSort) {
  //   if (sorter) this.dataSource.sort = sorter;
  // }



  constructor(){
    //this.dataSource = new MatTableDataSource(this.tableData);
  }

  ngOnChanges(){
    this.dataSource = new MatTableDataSource(this.tableData);
    this.displayedColumnsadd=[];
    this.displayedColumnsadd= this.displayedColumnsadd.concat(this.columns,this.displayedColumns);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  setDataSourceAttributes() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;

    if (this.paginator && this.sort) {
        this.applyFilter('');
    }
}
  
  applyFilter(event: any) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  update(element:any)
  {
    console.log("Actualizar");
  }
  
  onDelete(element:any)
  {
    this.deleteEvent.emit(element);
  }

  onUpdate(element:any) {
    this.updateEvent.emit(element);
  }
}
