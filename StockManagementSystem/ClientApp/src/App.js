import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';


import './custom.css'

import CustomerCreate from './components/core/customer/pages/CustomerCreate';
import CustomerList from './components/core/customer/pages/CustomerList';
import LogIn from './components/Auth/LogIn';
import Register from './components/Auth/Register';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/home' component={Home} />
        <Route path='/counter' component={Counter} />
            <Route path='/fetch-data' component={FetchData} />
            <Route path="/customerCreate" component={CustomerCreate}/>
            <Route path="/customerList" component={CustomerList} />
            <Route path="/register" component={Register} />

            <Route exact path="/" component={LogIn} />

      </Layout>
    );
  }
}

