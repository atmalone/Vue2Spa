import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import HomePage from 'components/home-page'
import StationData from 'components/station-data'


export const routes = [
  { name: 'home', path: '/', component: HomePage, display: 'Home', icon: 'home' },
  // { name: 'counter', path: '/counter', component: CounterExample, display: 'Counter', icon: 'graduation-cap' },
  // { name: 'fetch-datadata', path: '/fetch-data', component: FetchData, display: 'Fetch data', icon: 'list' },
  { name: 'station-data', path: '/station-data', component: StationData, display: 'Station data', icon: 'list' }
]
